namespace BL3SteamDownpatcher {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.VersionTitleLabel = new System.Windows.Forms.Label();
      this.VersionsCombo = new System.Windows.Forms.ComboBox();
      this.DownpatchButton = new System.Windows.Forms.Button();
      this.VerifyButton = new System.Windows.Forms.Button();
      this.PatchProgressBar = new System.Windows.Forms.ProgressBar();
      this.DLC1Check = new System.Windows.Forms.CheckBox();
      this.DLC2Check = new System.Windows.Forms.CheckBox();
      this.DLC3Check = new System.Windows.Forms.CheckBox();
      this.DLC4Check = new System.Windows.Forms.CheckBox();
      this.BL3OpenDialog = new System.Windows.Forms.OpenFileDialog();
      this.DDOpenDialog = new System.Windows.Forms.OpenFileDialog();
      this.CurrentVersionTable = new System.Windows.Forms.TableLayoutPanel();
      this.CurrentVersionLabel = new System.Windows.Forms.Label();
      this.DLCTable = new System.Windows.Forms.TableLayoutPanel();
      this.DLC6Check = new System.Windows.Forms.CheckBox();
      this.DLC5Check = new System.Windows.Forms.CheckBox();
      this.DownpatchTable = new System.Windows.Forms.TableLayoutPanel();
      this.HotfixButton = new System.Windows.Forms.Button();
      this.PathsTable = new System.Windows.Forms.TableLayoutPanel();
      this.DDPathButton = new System.Windows.Forms.Button();
      this.DDPathBox = new BL3SteamDownpatcher.HintTextBox();
      this.BL3PathButton = new System.Windows.Forms.Button();
      this.BL3PathBox = new BL3SteamDownpatcher.HintTextBox();
      this.OuterTable = new System.Windows.Forms.TableLayoutPanel();
      this.ExtrasTable = new System.Windows.Forms.TableLayoutPanel();
      this.SteamUserBox = new BL3SteamDownpatcher.HintTextBox();
      this.CurrentVersionTable.SuspendLayout();
      this.DLCTable.SuspendLayout();
      this.DownpatchTable.SuspendLayout();
      this.PathsTable.SuspendLayout();
      this.OuterTable.SuspendLayout();
      this.ExtrasTable.SuspendLayout();
      this.SuspendLayout();
      // 
      // VersionTitleLabel
      // 
      this.VersionTitleLabel.AutoSize = true;
      this.VersionTitleLabel.Location = new System.Drawing.Point(3, 8);
      this.VersionTitleLabel.Margin = new System.Windows.Forms.Padding(3, 8, 0, 8);
      this.VersionTitleLabel.Name = "VersionTitleLabel";
      this.VersionTitleLabel.Size = new System.Drawing.Size(82, 13);
      this.VersionTitleLabel.TabIndex = 0;
      this.VersionTitleLabel.Text = "Current Version:";
      // 
      // VersionsCombo
      // 
      this.VersionsCombo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.VersionsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.VersionsCombo.FormattingEnabled = true;
      this.VersionsCombo.Location = new System.Drawing.Point(3, 4);
      this.VersionsCombo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
      this.VersionsCombo.Name = "VersionsCombo";
      this.VersionsCombo.Size = new System.Drawing.Size(224, 21);
      this.VersionsCombo.TabIndex = 1;
      this.VersionsCombo.SelectedValueChanged += new System.EventHandler(this.VersionsCombo_SelectedValueChanged);
      // 
      // DownpatchButton
      // 
      this.DownpatchButton.Enabled = false;
      this.DownpatchButton.Location = new System.Drawing.Point(230, 3);
      this.DownpatchButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
      this.DownpatchButton.Name = "DownpatchButton";
      this.DownpatchButton.Size = new System.Drawing.Size(100, 23);
      this.DownpatchButton.TabIndex = 0;
      this.DownpatchButton.Text = "Downpatch";
      this.DownpatchButton.UseVisualStyleBackColor = true;
      this.DownpatchButton.Click += new System.EventHandler(this.DownpatchVerifyButton_Click);
      // 
      // VerifyButton
      // 
      this.VerifyButton.Location = new System.Drawing.Point(230, 3);
      this.VerifyButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
      this.VerifyButton.Name = "VerifyButton";
      this.VerifyButton.Size = new System.Drawing.Size(100, 23);
      this.VerifyButton.TabIndex = 2;
      this.VerifyButton.Text = "Verify Files";
      this.VerifyButton.UseVisualStyleBackColor = true;
      this.VerifyButton.Click += new System.EventHandler(this.DownpatchVerifyButton_Click);
      // 
      // PatchProgressBar
      // 
      this.PatchProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PatchProgressBar.Location = new System.Drawing.Point(3, 194);
      this.PatchProgressBar.Name = "PatchProgressBar";
      this.PatchProgressBar.Size = new System.Drawing.Size(327, 21);
      this.PatchProgressBar.TabIndex = 1;
      this.PatchProgressBar.Visible = false;
      // 
      // DLC1Check
      // 
      this.DLC1Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC1Check.AutoSize = true;
      this.DLC1Check.Location = new System.Drawing.Point(3, 5);
      this.DLC1Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC1Check.Name = "DLC1Check";
      this.DLC1Check.Size = new System.Drawing.Size(64, 17);
      this.DLC1Check.TabIndex = 0;
      this.DLC1Check.Text = "Jackpot";
      this.DLC1Check.UseVisualStyleBackColor = true;
      this.DLC1Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // DLC2Check
      // 
      this.DLC2Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC2Check.AutoSize = true;
      this.DLC2Check.Location = new System.Drawing.Point(114, 5);
      this.DLC2Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC2Check.Name = "DLC2Check";
      this.DLC2Check.Size = new System.Drawing.Size(69, 17);
      this.DLC2Check.TabIndex = 1;
      this.DLC2Check.Text = "Wedding";
      this.DLC2Check.UseVisualStyleBackColor = true;
      this.DLC2Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // DLC3Check
      // 
      this.DLC3Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC3Check.AutoSize = true;
      this.DLC3Check.Location = new System.Drawing.Point(225, 5);
      this.DLC3Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC3Check.Name = "DLC3Check";
      this.DLC3Check.Size = new System.Drawing.Size(59, 17);
      this.DLC3Check.TabIndex = 2;
      this.DLC3Check.Text = "Bounty";
      this.DLC3Check.UseVisualStyleBackColor = true;
      this.DLC3Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // DLC4Check
      // 
      this.DLC4Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC4Check.AutoSize = true;
      this.DLC4Check.Location = new System.Drawing.Point(3, 30);
      this.DLC4Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC4Check.Name = "DLC4Check";
      this.DLC4Check.Size = new System.Drawing.Size(50, 17);
      this.DLC4Check.TabIndex = 3;
      this.DLC4Check.Text = "Krieg";
      this.DLC4Check.UseVisualStyleBackColor = true;
      this.DLC4Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // BL3OpenDialog
      // 
      this.BL3OpenDialog.Filter = "Borderlands 3|Borderlands3.exe";
      // 
      // DDOpenDialog
      // 
      this.DDOpenDialog.Filter = "Depot Downloader|DepotDownloader.dll";
      // 
      // CurrentVersionTable
      // 
      this.CurrentVersionTable.ColumnCount = 3;
      this.CurrentVersionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.CurrentVersionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.CurrentVersionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.CurrentVersionTable.Controls.Add(this.CurrentVersionLabel, 1, 0);
      this.CurrentVersionTable.Controls.Add(this.VersionTitleLabel, 0, 0);
      this.CurrentVersionTable.Controls.Add(this.VerifyButton, 2, 0);
      this.CurrentVersionTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.CurrentVersionTable.Location = new System.Drawing.Point(0, 83);
      this.CurrentVersionTable.Margin = new System.Windows.Forms.Padding(0);
      this.CurrentVersionTable.Name = "CurrentVersionTable";
      this.CurrentVersionTable.RowCount = 1;
      this.CurrentVersionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.CurrentVersionTable.Size = new System.Drawing.Size(333, 29);
      this.CurrentVersionTable.TabIndex = 4;
      // 
      // CurrentVersionLabel
      // 
      this.CurrentVersionLabel.AutoSize = true;
      this.CurrentVersionLabel.Location = new System.Drawing.Point(85, 8);
      this.CurrentVersionLabel.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
      this.CurrentVersionLabel.Name = "CurrentVersionLabel";
      this.CurrentVersionLabel.Size = new System.Drawing.Size(53, 13);
      this.CurrentVersionLabel.TabIndex = 1;
      this.CurrentVersionLabel.Text = "Unknown";
      // 
      // DLCTable
      // 
      this.DLCTable.AutoSize = true;
      this.DLCTable.ColumnCount = 3;
      this.DLCTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.DLCTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.DLCTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.DLCTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.DLCTable.Controls.Add(this.DLC1Check, 0, 0);
      this.DLCTable.Controls.Add(this.DLC2Check, 1, 0);
      this.DLCTable.Controls.Add(this.DLC3Check, 2, 0);
      this.DLCTable.Controls.Add(this.DLC6Check, 2, 1);
      this.DLCTable.Controls.Add(this.DLC5Check, 1, 1);
      this.DLCTable.Controls.Add(this.DLC4Check, 0, 1);
      this.DLCTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DLCTable.Location = new System.Drawing.Point(0, 112);
      this.DLCTable.Margin = new System.Windows.Forms.Padding(0);
      this.DLCTable.Name = "DLCTable";
      this.DLCTable.RowCount = 2;
      this.DLCTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.DLCTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.DLCTable.Size = new System.Drawing.Size(333, 50);
      this.DLCTable.TabIndex = 5;
      // 
      // DLC6Check
      // 
      this.DLC6Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC6Check.AutoSize = true;
      this.DLC6Check.Location = new System.Drawing.Point(225, 30);
      this.DLC6Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC6Check.Name = "DLC6Check";
      this.DLC6Check.Size = new System.Drawing.Size(74, 17);
      this.DLC6Check.TabIndex = 5;
      this.DLC6Check.Text = "Raid Boss";
      this.DLC6Check.UseVisualStyleBackColor = true;
      this.DLC6Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // DLC5Check
      // 
      this.DLC5Check.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.DLC5Check.AutoSize = true;
      this.DLC5Check.Location = new System.Drawing.Point(114, 30);
      this.DLC5Check.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
      this.DLC5Check.Name = "DLC5Check";
      this.DLC5Check.Size = new System.Drawing.Size(78, 17);
      this.DLC5Check.TabIndex = 4;
      this.DLC5Check.Text = "Arms Race";
      this.DLC5Check.UseVisualStyleBackColor = true;
      this.DLC5Check.CheckedChanged += new System.EventHandler(this.DLCCheck_CheckedChanged);
      // 
      // DownpatchTable
      // 
      this.DownpatchTable.ColumnCount = 2;
      this.DownpatchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.DownpatchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.DownpatchTable.Controls.Add(this.VersionsCombo, 0, 0);
      this.DownpatchTable.Controls.Add(this.DownpatchButton, 1, 0);
      this.DownpatchTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DownpatchTable.Location = new System.Drawing.Point(0, 162);
      this.DownpatchTable.Margin = new System.Windows.Forms.Padding(0);
      this.DownpatchTable.Name = "DownpatchTable";
      this.DownpatchTable.RowCount = 1;
      this.DownpatchTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.DownpatchTable.Size = new System.Drawing.Size(333, 29);
      this.DownpatchTable.TabIndex = 0;
      // 
      // HotfixButton
      // 
      this.HotfixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.HotfixButton.Location = new System.Drawing.Point(230, 1);
      this.HotfixButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 3);
      this.HotfixButton.Name = "HotfixButton";
      this.HotfixButton.Size = new System.Drawing.Size(100, 23);
      this.HotfixButton.TabIndex = 1;
      this.HotfixButton.Text = "Enable Hotfixes";
      this.HotfixButton.UseVisualStyleBackColor = true;
      this.HotfixButton.Click += new System.EventHandler(this.HotfixButton_Click);
      // 
      // PathsTable
      // 
      this.PathsTable.ColumnCount = 2;
      this.PathsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.PathsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.PathsTable.Controls.Add(this.DDPathButton, 1, 1);
      this.PathsTable.Controls.Add(this.DDPathBox, 0, 1);
      this.PathsTable.Controls.Add(this.BL3PathButton, 1, 0);
      this.PathsTable.Controls.Add(this.BL3PathBox, 0, 0);
      this.PathsTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PathsTable.Location = new System.Drawing.Point(0, 0);
      this.PathsTable.Margin = new System.Windows.Forms.Padding(0);
      this.PathsTable.Name = "PathsTable";
      this.PathsTable.RowCount = 2;
      this.PathsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.PathsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.PathsTable.Size = new System.Drawing.Size(333, 56);
      this.PathsTable.TabIndex = 2;
      // 
      // DDPathButton
      // 
      this.DDPathButton.Image = global::BL3SteamDownpatcher.Properties.Resources.OpenFile;
      this.DDPathButton.Location = new System.Drawing.Point(305, 30);
      this.DDPathButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 1);
      this.DDPathButton.Name = "DDPathButton";
      this.DDPathButton.Size = new System.Drawing.Size(25, 25);
      this.DDPathButton.TabIndex = 3;
      this.DDPathButton.UseVisualStyleBackColor = true;
      this.DDPathButton.Click += new System.EventHandler(this.PathButton_Click);
      // 
      // DDPathBox
      // 
      this.DDPathBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DDPathBox.HintText = "DepotDownloader Path";
      this.DDPathBox.Location = new System.Drawing.Point(3, 32);
      this.DDPathBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
      this.DDPathBox.Name = "DDPathBox";
      this.DDPathBox.Size = new System.Drawing.Size(299, 20);
      this.DDPathBox.TabIndex = 2;
      this.DDPathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
      this.DDPathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
      // 
      // BL3PathButton
      // 
      this.BL3PathButton.Image = global::BL3SteamDownpatcher.Properties.Resources.OpenFile;
      this.BL3PathButton.Location = new System.Drawing.Point(305, 3);
      this.BL3PathButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 1);
      this.BL3PathButton.Name = "BL3PathButton";
      this.BL3PathButton.Size = new System.Drawing.Size(25, 25);
      this.BL3PathButton.TabIndex = 1;
      this.BL3PathButton.UseVisualStyleBackColor = true;
      this.BL3PathButton.Click += new System.EventHandler(this.PathButton_Click);
      // 
      // BL3PathBox
      // 
      this.BL3PathBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.BL3PathBox.HintText = "BL3 Path";
      this.BL3PathBox.Location = new System.Drawing.Point(3, 5);
      this.BL3PathBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 1);
      this.BL3PathBox.Name = "BL3PathBox";
      this.BL3PathBox.Size = new System.Drawing.Size(299, 20);
      this.BL3PathBox.TabIndex = 0;
      this.BL3PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
      this.BL3PathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
      // 
      // OuterTable
      // 
      this.OuterTable.AutoSize = true;
      this.OuterTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.OuterTable.ColumnCount = 1;
      this.OuterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
      this.OuterTable.Controls.Add(this.DownpatchTable, 0, 4);
      this.OuterTable.Controls.Add(this.DLCTable, 0, 3);
      this.OuterTable.Controls.Add(this.PatchProgressBar, 0, 5);
      this.OuterTable.Controls.Add(this.CurrentVersionTable, 0, 2);
      this.OuterTable.Controls.Add(this.PathsTable, 0, 0);
      this.OuterTable.Controls.Add(this.ExtrasTable, 0, 1);
      this.OuterTable.Location = new System.Drawing.Point(12, 12);
      this.OuterTable.Margin = new System.Windows.Forms.Padding(9);
      this.OuterTable.Name = "OuterTable";
      this.OuterTable.RowCount = 6;
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.OuterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.OuterTable.Size = new System.Drawing.Size(333, 218);
      this.OuterTable.TabIndex = 0;
      // 
      // ExtrasTable
      // 
      this.ExtrasTable.ColumnCount = 2;
      this.ExtrasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.ExtrasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.ExtrasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.ExtrasTable.Controls.Add(this.SteamUserBox, 0, 0);
      this.ExtrasTable.Controls.Add(this.HotfixButton, 1, 0);
      this.ExtrasTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ExtrasTable.Location = new System.Drawing.Point(0, 56);
      this.ExtrasTable.Margin = new System.Windows.Forms.Padding(0);
      this.ExtrasTable.Name = "ExtrasTable";
      this.ExtrasTable.RowCount = 1;
      this.ExtrasTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.ExtrasTable.Size = new System.Drawing.Size(333, 27);
      this.ExtrasTable.TabIndex = 3;
      // 
      // SteamUserBox
      // 
      this.SteamUserBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SteamUserBox.HintText = "Steam Username";
      this.SteamUserBox.Location = new System.Drawing.Point(3, 3);
      this.SteamUserBox.Name = "SteamUserBox";
      this.SteamUserBox.Size = new System.Drawing.Size(160, 20);
      this.SteamUserBox.TabIndex = 0;
      this.SteamUserBox.TextChanged += new System.EventHandler(this.SteamUserBox_TextChanged);
      this.SteamUserBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(357, 242);
      this.Controls.Add(this.OuterTable);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Text = "BL3 Steam Downpatcher";
      this.CurrentVersionTable.ResumeLayout(false);
      this.CurrentVersionTable.PerformLayout();
      this.DLCTable.ResumeLayout(false);
      this.DLCTable.PerformLayout();
      this.DownpatchTable.ResumeLayout(false);
      this.PathsTable.ResumeLayout(false);
      this.PathsTable.PerformLayout();
      this.OuterTable.ResumeLayout(false);
      this.OuterTable.PerformLayout();
      this.ExtrasTable.ResumeLayout(false);
      this.ExtrasTable.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button BL3PathButton;
    private System.Windows.Forms.Label VersionTitleLabel;
    private System.Windows.Forms.ComboBox VersionsCombo;
    private System.Windows.Forms.Button DownpatchButton;
    private System.Windows.Forms.Button DDPathButton;
    private HintTextBox DDPathBox;
    private HintTextBox BL3PathBox;
    private System.Windows.Forms.OpenFileDialog BL3OpenDialog;
    private System.Windows.Forms.OpenFileDialog DDOpenDialog;
    private System.Windows.Forms.ProgressBar PatchProgressBar;
    private System.Windows.Forms.CheckBox DLC1Check;
    private System.Windows.Forms.CheckBox DLC2Check;
    private System.Windows.Forms.CheckBox DLC3Check;
    private System.Windows.Forms.CheckBox DLC4Check;
    private System.Windows.Forms.Button VerifyButton;
    private HintTextBox SteamUserBox;
    private System.Windows.Forms.Button HotfixButton;
    private System.Windows.Forms.Label CurrentVersionLabel;
    private System.Windows.Forms.TableLayoutPanel DLCTable;
    private System.Windows.Forms.TableLayoutPanel CurrentVersionTable;
    private System.Windows.Forms.TableLayoutPanel DownpatchTable;
    private System.Windows.Forms.TableLayoutPanel PathsTable;
    private System.Windows.Forms.TableLayoutPanel OuterTable;
    private System.Windows.Forms.TableLayoutPanel ExtrasTable;
    private System.Windows.Forms.CheckBox DLC6Check;
    private System.Windows.Forms.CheckBox DLC5Check;
  }
}

