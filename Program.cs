using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL3SteamDownpatcher {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args) {
      if (args.Length > 0) {
        if (args[0] == HotfixManager.ARG_HOTFIX_ON) {
          HotfixManager.AdminTurnOn();
        } else if (args[0] == HotfixManager.ARG_HOTFIX_OFF) {
          HotfixManager.AdminTurnOff();
        }
      } else {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
      }
    }
  }
}
