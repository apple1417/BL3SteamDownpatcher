using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL3SteamDownpatcher {
  [Flags]
  public enum Depot {
    None = 0,
    Exe = 1,
    Content = 2,
    Dandelion = 4,
    Hibiscus = 8,
    Geranium = 16,
    Alisma = 32,
    Ixora = 64,
    DLC6 = 128,

    Base = Exe | Content
  }

  static partial class SteamManager {
    private const uint APP_ID = 397540;

    private static readonly Dictionary<Depot, int> DEPOT_IDS = new Dictionary<Depot, int>() {
      { Depot.Exe, 397542 },
      { Depot.Content, 397541 },
      { Depot.Dandelion, 1232256 },
      { Depot.Hibiscus, 1232257 },
      { Depot.Geranium, 1233060 },
      { Depot.Alisma, 1233061 },
      { Depot.Ixora, 1361830 }
    };

    private static readonly Dictionary<Depot, string> DLC_INSTALLED_FILES = new Dictionary<Depot, string>() {
      { Depot.Dandelion, "OakGame/AdditionalContent/Dandelion/Paks/Dandelion.pak" },
      { Depot.Hibiscus, "OakGame/AdditionalContent/Hibiscus/Paks/Hibiscus.pak" },
      { Depot.Geranium, "OakGame/AdditionalContent/Geranium/Paks/Geranium.pak" },
      { Depot.Alisma, "OakGame/AdditionalContent/Alisma/Paks/Alisma.pak" },
      { Depot.Ixora, "OakGame/AdditionalContent/Ixora/Paks/Ixora.pak" }
    };

    // All instances of this are defined in `SteamManagerVersions.cs`
    private class VersionInfo {
      public string Name;
      public string ProductVersion;

      public Dictionary<Depot, ulong> Manifests;

      public Dictionary<Depot, HashSet<string>> FilesToAdd = new Dictionary<Depot, HashSet<string>>();
      public Dictionary<Depot, HashSet<string>> FilesToDelete = new Dictionary<Depot, HashSet<string>>();
      public Dictionary<Depot, HashSet<string>> FilesToReplace = new Dictionary<Depot, HashSet<string>>();
    }

    public static string TryFindExe() {
      // Try check with a registry key first
      RegistryKey regLM = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
      string regKey = $"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App {APP_ID}";
      string regLocation = (string) regLM.OpenSubKey(regKey)?.GetValue("InstallLocation");
      if (!(regLocation is null)) {
        string regFull = Path.Combine(regLocation, "OakGame", "Binaries", "Win64", "Borderlands3.exe");
        if (File.Exists(regFull)) {
          return regFull;
        }
      }

      // Find all steam libraries
      string steamapps = "C:\\Program Files (x86)\\Steam\\steamapps";
      string libraryFolders = Path.Combine(steamapps, "libraryfolders.vdf");
      if (!File.Exists(libraryFolders)) {
        return null;
      }
      List<string> steamLibraries = new List<string>() { steamapps };
      foreach (Match m in Regex.Matches(File.ReadAllText(libraryFolders), "\\t+\"\\d+\"\\t+\"(.+?)\"")) {
        string dir = m.Groups[1].Value.Replace(@"\\", @"\");
        if (Directory.Exists(dir)) {
          steamLibraries.Add(Path.Combine(dir, "steamapps")); ;
        }
      }

      // Check if BL3 is installed in this library
      foreach (string location in steamLibraries) {
        if (!File.Exists(Path.Combine(location, $"appmanifest_{APP_ID}.acf"))) {
          continue;
        }

        string exe = Path.Combine(location, "common", "Borderlands 3", "OakGame", "Binaries", "Win64", "Borderlands3.exe");
        if (File.Exists(exe)) {
          return exe;
        }
      }

      return null;
    }
    
    public static Depot GetInstalledDLC(string bl3Path) {
      Depot output = Depot.Base;
      string basePath = new DirectoryInfo(bl3Path).Parent.Parent.Parent.Parent.FullName;

      foreach (KeyValuePair<Depot, string> entry in DLC_INSTALLED_FILES) {
        if (File.Exists(Path.Combine(basePath, entry.Value))) {
          output |= entry.Key;
        }
      }

      return output;
    }

    public static IEnumerable<string> GetAllVersions() => AllVersionInfo.Select(x => x.ProductVersion);
    public static string GetVersionName(string version) => AllVersionInfo.Find(x => x.ProductVersion == version)?.Name;
    public static bool IsValidVersion(string version) => AllVersionInfo.Any(x => x.ProductVersion == version);

    public static Depot GetSupportedDepots(string version) {
      return AllVersionInfo.Find(x => x.ProductVersion == version).Manifests.Keys.Aggregate((a, b) => a | b);
    }

    public static async Task<bool> SwitchVersion(
      string currentVersion,
      string newVersion,
      Depot currentDLC,
      Depot newDLC,
      string bl3Path,
      string ddPath,
      string username,
      Action<int> setBarMax,
      Action<int> setBarValue,
      Action incrementBar
    ) {
      return await Task.Run(() => InternalSwitchVersion(
        currentVersion,
        newVersion,
        currentDLC,
        newDLC,
        bl3Path,
        ddPath,
        username,
        setBarMax,
        setBarValue,
        incrementBar
      ));
    }

    public static async Task<bool> VerifyVersion(
      string currentVersion,
      Depot currentDLC,
      string bl3Path,
      string ddPath,
      string username,
      Action<int> setBarMax,
      Action<int> setBarValue,
      Action incrementBar
    ) {
      return await Task.Run(() => InternalVerifyVersion(
        currentVersion,
        currentDLC,
        bl3Path,
        ddPath,
        username,
        setBarMax,
        setBarValue,
        incrementBar
      ));
    }

    private static HashSet<string> GetAllRemovedDLCFiles(Depot wantedDLC) {
      HashSet<string> allFiles = new HashSet<string>();
      foreach (Depot dlc in new List<Depot>() { Depot.Dandelion, Depot.Hibiscus, Depot.Geranium, Depot.Alisma }) {
        if (wantedDLC.HasFlag(dlc)) {
          continue;
        }

        for (int idx = AllVersionInfo.Count - 1; idx >= 0; idx--) {
          VersionInfo info = AllVersionInfo[idx];

          if (info.FilesToAdd.ContainsKey(dlc)) {
            foreach (string file in info.FilesToAdd[dlc]) {
              allFiles.Add(file);
            }
          }
          if (info.FilesToDelete.ContainsKey(dlc)) {
            foreach (string file in info.FilesToAdd[dlc]) {
              allFiles.Add(file);
            }
          }
          if (info.FilesToReplace.ContainsKey(dlc)) {
            foreach (string file in info.FilesToAdd[dlc]) {
              allFiles.Add(file);
            }
          }
        }
      }

      return allFiles;
    }

    private static bool InternalSwitchVersion(
      string currentVersion,
      string newVersion,
      Depot currentDLC,
      Depot newDLC,
      string bl3Path,
      string ddPath,
      string username,
      Action<int> setBarMax,
      Action<int> setBarValue,
      Action incrementBar
    ) {
      /*
        How switching versions works
        ============================
        Switching versions will upgrade/downgrade through every version between the current and the target.
        This will be combined into one operation, no need to replace the same files multiple times.

        We use the fields from `VersionInfo` as follows.
        Note that upgrading refers to upgrading *to* the relevant version, while downgrading refers to downgrading *from* it.

        FilesToAdd:
          When upgrading, all these files get added.
          When downgrading, all these files get deleted.
        FilesToDelete:
          When upgrading, all these files get deleted.
          When downgrading, all these files get added again, from the version before this one.
        FilesToReplace:
          Behaves like `FilesToAdd` when upgrading.
          Behaves like `FilesToDelete` when downgrading.

        Because we want to cache downloads, we store the manifest of the version we discovered a file alongside it.
        Future calls will discover it at the same version, and can find it in the same place in our cache.
        We make sure to validate files every download though incase some corrupted.

        While iterating, if a file is added then deleted (or vice versa) only the latest state is saved.
        We also update manifests when this happens, as the file might have changed inbetween.

        DLCs and the base game work mostly the same, only difference is DLCs need to specify all their files as `FilesToAdd` on
         their lowest version, so that we have a full list to delete when uninstalling.
      */

      currentDLC |= Depot.Base;
      newDLC = (newDLC & GetSupportedDepots(newVersion)) | Depot.Base;

      int currentIdx = AllVersionInfo.FindIndex(x => x.ProductVersion == currentVersion);
      int newIdx = AllVersionInfo.FindIndex(x => x.ProductVersion == newVersion);

      bool upgrading = currentIdx < newIdx;

      // Also store the depot/manifest to get each file from
      Dictionary<string, (Depot dep, VersionInfo info)> filesToAdd = new Dictionary<string, (Depot dep, VersionInfo info)>();
      HashSet<string> filesToDelete = new HashSet<string>();

      Action<Dictionary<Depot, HashSet<string>>, VersionInfo> addFiles = (dict, info) => {
        foreach (KeyValuePair<Depot, HashSet<string>> entry in dict) {
          if (!newDLC.HasFlag(entry.Key)) {
            continue; // We'll deal with uninstalled dlc files later
          }
          foreach (string file in entry.Value) {
            filesToAdd[file] = (entry.Key, info);
            filesToDelete.Remove(file);
          }
        }
      };

      Action<Dictionary<Depot, HashSet<string>>> removeFiles = dict => {
        foreach (KeyValuePair<Depot, HashSet<string>> entry in dict) {
          if (!newDLC.HasFlag(entry.Key)) {
            continue;
          }
          foreach (string file in entry.Value) {
            filesToAdd.Remove(file);
            filesToDelete.Add(file);
          }
        }
      };

      if (upgrading) {
        // Ignore the current version, include the new one
        for (int idx = currentIdx + 1; idx <= newIdx; idx++) {
          VersionInfo info = AllVersionInfo[idx];
          removeFiles(info.FilesToDelete);
          addFiles(info.FilesToAdd, info);
          addFiles(info.FilesToReplace, info);
        }
      } else {
        // Include the current version, ignore the new one
        for (int idx = currentIdx; idx > newIdx; idx--) {
          VersionInfo info = AllVersionInfo[idx];
          removeFiles(info.FilesToAdd);
          // We want to redownload deleted files from the version before this one
          // Because we don't iterate over the new version this is always safe
          addFiles(info.FilesToDelete, AllVersionInfo[idx - 1]);
          addFiles(info.FilesToReplace, AllVersionInfo[idx - 1]);
        }
      }

      foreach (string file in GetAllRemovedDLCFiles(newDLC)) {
        filesToAdd.Remove(file);
        filesToDelete.Add(file);
      }

      // Reverse `filesToAdd`
      // It's more convenient to have file keys while gathering files, but manifest keys when downloading manifests
      Dictionary<(Depot dep, VersionInfo info), HashSet<string>> manifestsToDownload = new Dictionary<(Depot dep, VersionInfo info), HashSet<string>>();
      foreach (KeyValuePair<string, (Depot dep, VersionInfo info)> entry in filesToAdd) {
        if (!manifestsToDownload.ContainsKey(entry.Value)) {
          manifestsToDownload[entry.Value] = new HashSet<string>();
        }
        manifestsToDownload[entry.Value].Add(entry.Key);
      }

      string baseCachePath = Path.Combine(Directory.GetCurrentDirectory(), "Downpatcher Cache");
      string filelist = Path.Combine(baseCachePath, "filelist.txt");
      Directory.CreateDirectory(baseCachePath);

      bool anyErrors = false;
      setBarMax(manifestsToDownload.Keys.Count + 1);
      setBarValue(1);
      foreach (KeyValuePair<(Depot dep, VersionInfo info), HashSet<string>> entry in manifestsToDownload) {
        string version_name = entry.Key.info.ProductVersion;
        int depot_id = DEPOT_IDS[entry.Key.dep];
        ulong manifest_id = entry.Key.info.Manifests[entry.Key.dep];

        string cachePath = Path.Combine(baseCachePath, version_name);

        using (FileStream stream = File.Create(filelist))
        using (StreamWriter writer = new StreamWriter(stream)) {
          foreach (string file in entry.Value) {
            writer.WriteLine(file);
          }
        }

        Process ddProc = null;
        try {
          ddProc = Process.Start(
            "dotnet",
            $"\"{ddPath}\""
            + $" -user \"{username}\" -remember-password"
            + $" -app {APP_ID} -depot {depot_id} -manifest {manifest_id}"
            + $" -dir \"{cachePath}\" -filelist \"{filelist}\" -validate"
          );
          ddProc.WaitForExit();
        } catch (FileNotFoundException) {
          MessageBox.Show(
            $"Unable to launch Depot Downloader. Downpatching will be aborted",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
          return true;
        }

        if (ddProc.ExitCode != 0) {
          // I really wish there was a good way for me to log the console output somewhere
          // The exit code is only ever 0/1 so I can't really tell what sort of error happened either
          MessageBox.Show(
            $"Depot Downloader did not exit succesfully. '{entry.Key.info.ProductVersion}/{entry.Key.dep}' may not have been properly downloaded.",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
          anyErrors = true;
        }

        // There seem to be some problems if you re-launch depotdownloader too fast
        Thread.Sleep(1500);
        incrementBar();
      }

      // Check that all files were properly downloaded
      HashSet<string> missingFiles = new HashSet<string>();
      foreach (KeyValuePair<(Depot dep, VersionInfo info), HashSet<string>> entry in manifestsToDownload) {
        string cachePath = Path.Combine(baseCachePath, entry.Key.info.ProductVersion);
        foreach (string file in entry.Value) {
          if (!File.Exists(Path.Combine(cachePath, file))) {
            missingFiles.Add(file);
          }
        }
      }
      if (missingFiles.Count > 0) {
        MessageBox.Show(
          "Some files failed to download. Downpatching will be aborted.\n\n" + string.Join("\n", missingFiles),
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error
        );
        return true;
      } else if (anyErrors) {
        DialogResult result = MessageBox.Show(
          "Depot Downloader exited unsucessfully at least once, but all files seem to exist. Some of these may be corrupt. Do you want to continue?",
          "Continue",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning
        );

        if (result == DialogResult.No) {
          return true;
        }
      }

      string baseBL3Path = new DirectoryInfo(bl3Path).Parent.Parent.Parent.Parent.FullName;
      
      setBarMax(filesToDelete.Count + filesToAdd.Count);
      setBarValue(0);
      foreach (string file in filesToDelete) {
        File.Delete(Path.Combine(baseBL3Path, file));
        incrementBar();
      }
      foreach (KeyValuePair<(Depot dep, VersionInfo info), HashSet<string>> entry in manifestsToDownload) {
        string cachePath = Path.Combine(baseCachePath, entry.Key.info.ProductVersion);
        foreach (string file in entry.Value) {
          string src = Path.Combine(cachePath, file);
          string dst = Path.Combine(baseBL3Path, file);
          Directory.CreateDirectory(Path.GetDirectoryName(dst));
          File.Copy(src, dst, true);
          incrementBar();
        }
      }

      return false;
    }


    private static bool InternalVerifyVersion(
      string currentVersion,
      Depot currentDLC,
      string bl3Path,
      string ddPath,
      string username,
      Action<int> setBarMax,
      Action<int> setBarValue,
      Action incrementBar
    ) {
      /*
        How verifying files works
        =========================
        When verifying files, we only need to make sure no extra files exist.
        DepotDownloader will make sure to download any files that we're missing, or that were modified.

        This time we iterate through all versions, and change behavior based on if we're before/after the current version.

        When below or equal to the current version, delete all `FilesToDelete`.
        If a file is added again later (while still below/equal to), remove it from the list.

        When above the current version, delete all `FilesToAdd`, even if it's later deleted.

        Ignore `FilesToRemove`, DepotDownloader will fix them.        

        DLCs work mostly the same again, and if we're not supposed to have one then delete all related files.
      */
      currentDLC = (currentDLC & GetSupportedDepots(currentVersion)) | Depot.Base;

      HashSet<string> filesToDelete = new HashSet<string>();

      bool belowCurrent = true;
      for (int idx = 0; idx < AllVersionInfo.Count; idx++) {
        VersionInfo info = AllVersionInfo[idx];

        if (belowCurrent) {
          foreach (KeyValuePair<Depot, HashSet<string>> entry in info.FilesToDelete) {
            if (!currentDLC.HasFlag(entry.Key)) {
              continue;
            }
            filesToDelete.UnionWith(entry.Value);
          }
          foreach (KeyValuePair<Depot, HashSet<string>> entry in info.FilesToAdd) {
            if (!currentDLC.HasFlag(entry.Key)) {
              continue;
            }
            filesToDelete.RemoveWhere(x => entry.Value.Contains(x));
          }
        } else {
          foreach (KeyValuePair<Depot, HashSet<string>> entry in info.FilesToAdd) {
            if (!currentDLC.HasFlag(entry.Key)) {
              continue;
            }
            filesToDelete.UnionWith(entry.Value);
          }
        }

        if (info.ProductVersion == currentVersion) {
          belowCurrent = false;
        }
      }

      filesToDelete.UnionWith(GetAllRemovedDLCFiles(currentDLC));

      string basePath = new DirectoryInfo(bl3Path).Parent.Parent.Parent.Parent.FullName;

      setBarMax(filesToDelete.Count);
      setBarValue(0);
      foreach (string file in filesToDelete) {
        try {
          File.Delete(Path.Combine(basePath, file));
        } catch (DirectoryNotFoundException) { }
        incrementBar();
      }

      // Split out the flags enum into individual values
      // Could do this in one loop but I want to get length for the progress bar :)
      List<Depot> depotsToRun = new List<Depot>();
      foreach (Depot dep in Enum.GetValues(Depot.None.GetType())) {
        if (currentDLC.HasFlag(dep) && dep != Depot.None && dep != Depot.Base) {
          depotsToRun.Add(dep);
        }
      }

      Dictionary<Depot, ulong> manifests = AllVersionInfo.Find(x => x.ProductVersion == currentVersion).Manifests;

      setBarMax(depotsToRun.Count + 1);
      setBarValue(1);
      foreach (Depot dep in depotsToRun) {
        Process ddProc = Process.Start(
          "dotnet",
          $"\"{ddPath}\""
          + $" -user \"{username}\" -remember-password"
          + $" -app {APP_ID} -depot {DEPOT_IDS[dep]} -manifest {manifests[dep]}"
          + $" -dir \"{basePath}\" -validate"
        );
        ddProc.WaitForExit();

        if (ddProc.ExitCode != 0) {
          MessageBox.Show(
            $"Depot Downloader did not exit succesfully. The \"{dep}\" depot may not have been properly verified.",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
        }

        Thread.Sleep(1500);
        incrementBar();
      }

      return false;
    }
  }
}
