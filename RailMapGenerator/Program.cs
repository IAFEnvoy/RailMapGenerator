using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    internal static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main(string[] args) {
            if (args.Length == 2 && args[0] == "--server") {

            } else {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(args.Length >= 1 ? args[0] : null));
            }
        }
    }
}
