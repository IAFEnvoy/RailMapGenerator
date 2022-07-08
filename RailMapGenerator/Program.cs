using System;
using System.IO;
using System.Windows.Forms;

namespace RailMapGenerator {
    internal static class Program {
        private static readonly string[] dlls = new string[] { "Newtonsoft.Json.dll" };
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            foreach (string s in dlls)
                if (!File.Exists(Application.StartupPath + @"\" + s)) {
                    MessageBox.Show("无法运行此程序，因为缺少" + s, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
