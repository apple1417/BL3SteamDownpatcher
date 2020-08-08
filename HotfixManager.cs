using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL3SteamDownpatcher {
  static class HotfixManager {
    public const string ARG_HOTFIX_ON = "HotfixOn";
    public const string ARG_HOTFIX_OFF = "HotfixOff";

    public static readonly string HOSTS_FILE = Path.Combine(Environment.SystemDirectory, "drivers", "etc", "hosts");

    public static bool AreHotfixesOn() {
      using (StreamReader reader = new StreamReader(HOSTS_FILE)) {
        while (!reader.EndOfStream) {
          if (Regex.IsMatch(reader.ReadLine(), @"^127\.0\.0\.1\s+?discovery\.services\.gearboxsoftware\.com$")) {
            return false;
          }
        }
      }
      return true;
    }

    public static void RestartTurnOn() => InternalRestart(true);
    public static void RestartTurnOff() => InternalRestart(false);

    public static void AdminTurnOn() => InternalEditHosts(true);

    public static void AdminTurnOff() => InternalEditHosts(false);


    private static void InternalRestart(bool enable) {
      try {
        Process.Start(new ProcessStartInfo() {
          FileName = Process.GetCurrentProcess().MainModule.FileName,
          Arguments = enable ? ARG_HOTFIX_ON : ARG_HOTFIX_OFF,
          Verb = "runas"
        }).WaitForExit();
      // If the user denies admin
      } catch (Win32Exception) { }
    }

    private static void InternalEditHosts(bool enable) {
      string hotfix_re = @"127\.0\.0\.1\s+?discovery\.services\.gearboxsoftware\.com$";
      string replacement_line = "127.0.0.1    discovery.services.gearboxsoftware.com";
      if (enable) {
        hotfix_re = @"^" + hotfix_re;
        replacement_line = "# " + replacement_line;
      } else {
        hotfix_re = @"^(#\s+?)?" + hotfix_re;
      }

      bool foundLine = false;
      string hostContents = "";
      using (StreamReader reader = new StreamReader(HOSTS_FILE)) {
        while (!reader.EndOfStream) {
          string line = reader.ReadLine();
          if (Regex.IsMatch(line, hotfix_re)) {
            hostContents += replacement_line + Environment.NewLine;
            foundLine = true;
          } else {
            hostContents += line + Environment.NewLine;
          }
        }
      }

      if (!enable && !foundLine) {
        hostContents += replacement_line + Environment.NewLine;
      }

      File.WriteAllText(HOSTS_FILE, hostContents);
    }
  }
}
