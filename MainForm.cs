using BL3SteamDownpatcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BL3SteamDownpatcher {
  public partial class MainForm : Form {
    private const string DISABLE_HOTFIXES = "Disable Hotfixes";
    private const string ENABLE_HOTFIXES = "Enable Hotfixes";

    private string ValidatedBL3Path {
      get {
        return File.Exists(BL3PathBox.Text) && BL3PathBox.Text.EndsWith(
          "Borderlands3.exe", StringComparison.OrdinalIgnoreCase
        ) ? BL3PathBox.Text : null;
      }
    }

    private string ValidatedDDPath {
      get {
        return File.Exists(DDPathBox.Text) && DDPathBox.Text.EndsWith(
          "DepotDownloader.dll",  StringComparison.OrdinalIgnoreCase
        ) ? DDPathBox.Text : null;
      }
    }

    private string CurrentVersion = null;
    private Depot CurrentDLC = Depot.None;

    private readonly Dictionary<Button, (OpenFileDialog dialog, HintTextBox box)> PathButtonMap;
    private readonly Dictionary<string, string> VersionComboMap;

    public MainForm() {
      InitializeComponent();

      VersionComboMap = new Dictionary<string, string>();
      foreach (string version in SteamManager.GetAllVersions()) {
        string name = SteamManager.GetVersionName(version);
        string comboName = $"{name} ({version})";
        VersionsCombo.Items.Add(comboName);
        VersionComboMap[comboName] = version;
      }
      
      BL3PathBox.Text = Settings.Default.BL3Path.Length > 0 ? Settings.Default.BL3Path : SteamManager.TryFindExe() ?? "";
      DDPathBox.Text = Settings.Default.DDPath.Length > 0 ? Settings.Default.DDPath : "";
      SteamUserBox.Text = Settings.Default.SteamUsername.Length > 0 ? Settings.Default.SteamUsername : "";

      PathButtonMap = new Dictionary<Button, (OpenFileDialog dialog, HintTextBox box)>() {
        { BL3PathButton, (BL3OpenDialog, BL3PathBox) },
        { DDPathButton, (DDOpenDialog, DDPathBox) }
      };

      if (!(ValidatedBL3Path is null)) {
        CurrentDLC = SteamManager.GetInstalledDLC(ValidatedBL3Path);
      }

      HotfixButton.Text = HotfixManager.AreHotfixesOn() ? DISABLE_HOTFIXES : ENABLE_HOTFIXES;
    }

    private void PathButton_Click(object sender, EventArgs e) {
      OpenFileDialog dialog = PathButtonMap[(Button) sender].dialog;
      HintTextBox box = PathButtonMap[(Button) sender].box;

      dialog.FileName = box.Text;
      if (dialog.ShowDialog() == DialogResult.OK) {
        box.Text = dialog.FileName;
      }
    }

    private void PathBox_TextChanged(object sender, EventArgs e) {
      if ((sender == BL3PathBox ? ValidatedBL3Path : ValidatedDDPath) is null) {
        ((HintTextBox) sender).ForeColor = Color.Red;
      } else {
        ((HintTextBox) sender).ForeColor = Color.Black;

        if (sender == BL3PathBox) {
          UpdateVersionInfo();
        }
      }
      UpdateDownpatchVerifyButtons();
    }

    private void TextBox_KeyDown(object sender, KeyEventArgs e) {
      // Prevents the error sounds
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape) {
        e.SuppressKeyPress = true;
      }
    }


    private void VersionsCombo_SelectedValueChanged(object sender, EventArgs e) {
      UpdateDownpatchVerifyButtons();
      UpdateUsableCheckboxes();
    }

    private void DLCCheck_CheckedChanged(object sender, EventArgs e) => UpdateDownpatchVerifyButtons();

    private void SteamUserBox_TextChanged(object sender, EventArgs e) => UpdateDownpatchVerifyButtons();

    private void UpdateVersionInfo() {
      if (ValidatedBL3Path is null) {
        return;
      }

      string version = FileVersionHelper.GetProductVersion(ValidatedBL3Path);
      CurrentVersionLabel.Text = version;

      if (SteamManager.IsValidVersion(version)) {
        CurrentVersion = version;
        UpdateUsableCheckboxes();

        VersionsCombo.SelectedItem = VersionComboMap.Where(x => x.Value == version).FirstOrDefault().Key;

        CurrentDLC = SteamManager.GetInstalledDLC(ValidatedBL3Path);
        DLC1Check.Checked = CurrentDLC.HasFlag(Depot.Dandelion);
        DLC2Check.Checked = CurrentDLC.HasFlag(Depot.Hibiscus);
        DLC3Check.Checked = CurrentDLC.HasFlag(Depot.Geranium);
        DLC4Check.Checked = CurrentDLC.HasFlag(Depot.Alisma);

        string name = SteamManager.GetVersionName(version);
        CurrentVersionLabel.ForeColor = Color.Black;
      } else {
        CurrentVersion = null;
        CurrentVersionLabel.ForeColor = Color.Red;
      }
    }

    private void UpdateUsableCheckboxes() {
      if (!(VersionsCombo.SelectedItem is null)) {
        string selectedVersion = VersionComboMap[(string)VersionsCombo.SelectedItem];
        Depot supported = SteamManager.GetSupportedDepots(selectedVersion);
        DLC1Check.Enabled = supported.HasFlag(Depot.Dandelion);
        DLC2Check.Enabled = supported.HasFlag(Depot.Hibiscus);
        DLC3Check.Enabled = supported.HasFlag(Depot.Geranium);
        DLC4Check.Enabled = supported.HasFlag(Depot.Alisma);
      }
    }

    public Depot GetCheckedDLC() {
      Depot dlc = Depot.Base;
      dlc |= DLC1Check.Checked ? Depot.Dandelion : Depot.None;
      dlc |= DLC2Check.Checked ? Depot.Hibiscus : Depot.None;
      dlc |= DLC3Check.Checked ? Depot.Geranium : Depot.None;
      dlc |= DLC4Check.Checked ? Depot.Alisma : Depot.None;
      return dlc;
    }

    private void UpdateDownpatchVerifyButtons() {
      if (
        ValidatedBL3Path is null
        || ValidatedDDPath is null
        || CurrentVersion is null
        || VersionsCombo.SelectedItem is null
        || SteamUserBox.Text.Length == 0
        || PatchProgressBar.Visible
      ) {
        DownpatchButton.Enabled = false;
        VerifyButton.Enabled = false;
        return;
      }

      DownpatchButton.Enabled = VersionComboMap[(string) VersionsCombo.SelectedItem] != CurrentVersion || CurrentDLC != GetCheckedDLC();
      VerifyButton.Enabled = true;
    }

    private async void DownpatchVerifyButton_Click(object sender, EventArgs e) {
      // Most of these are the same as things that disable the buttons, but can never be too careful
      if (
        ValidatedBL3Path is null
        || ValidatedDDPath is null
        || CurrentVersion is null
        || VersionsCombo.SelectedItem is null
        || SteamUserBox.Text.Length == 0
        || PatchProgressBar.Visible
      ) {
        return;
      }

      string newVersion = VersionComboMap[(string) VersionsCombo.SelectedItem];
      Depot newDLC = GetCheckedDLC();

      bool isDownpatch = sender == DownpatchButton;

      if (isDownpatch) {
        if (CurrentVersion == newVersion && CurrentDLC == newDLC) {
          return;
        }
      }

      Settings.Default.BL3Path = ValidatedBL3Path;
      Settings.Default.DDPath = ValidatedDDPath;
      Settings.Default.SteamUsername = SteamUserBox.Text;
      Settings.Default.Save();

      PatchProgressBar.Visible = true;
      UpdateDownpatchVerifyButtons();

      DateTime startTime = DateTime.Now;

      bool suppressMessage = false;
      if (isDownpatch) {
        suppressMessage = await SteamManager.SwitchVersion(
          CurrentVersion,
          newVersion,
          CurrentDLC,
          newDLC,
          ValidatedBL3Path,
          ValidatedDDPath,
          SteamUserBox.Text,
          // Controls can't be accessed cross-thread making this awkward
          (x) => { Invoke(new Action(() => { PatchProgressBar.Maximum = x; })); },
          (x) => { Invoke(new Action(() => { PatchProgressBar.Value = x; })); },
          () => { Invoke(new Action(() => { PatchProgressBar.Value++; })); }
        );
      } else  {
        suppressMessage = await SteamManager.VerifyVersion(
          CurrentVersion,
          CurrentDLC,
          ValidatedBL3Path,
          ValidatedDDPath,
          SteamUserBox.Text,
          (x) => { Invoke(new Action(() => { PatchProgressBar.Maximum = x; })); },
          (x) => { Invoke(new Action(() => { PatchProgressBar.Value = x; })); },
          () => { Invoke(new Action(() => { PatchProgressBar.Value++; })); }
        );
      }

      DateTime finishTime = DateTime.Now;

      PatchProgressBar.Visible = false;
      UpdateDownpatchVerifyButtons();
      UpdateVersionInfo();

      // Don't bother showing a message if downpatch was quick.
      if (finishTime - startTime > TimeSpan.FromMinutes(1) && !suppressMessage) {
        MessageBox.Show((isDownpatch ? "Downpatching" : "File Verification") + " finished.");
      }
    }

    private void HotfixButton_Click(object sender, EventArgs e) {
      if (HotfixButton.Text == DISABLE_HOTFIXES) {
        HotfixManager.RestartTurnOff();
      } else {
        HotfixManager.RestartTurnOn();
      }

      // Check new state incase the user canceled admin
      HotfixButton.Text = HotfixManager.AreHotfixesOn() ? DISABLE_HOTFIXES : ENABLE_HOTFIXES;
    }
  }
}
