using Microsoft.Win32;
using System;
using System.Windows.Forms;

#pragma warning disable CA1416
namespace RailMapGenerator {
    internal class FileBind {
        public static void ExecuteBind() {
            RegistryKey regKey = Registry.ClassesRoot.CreateSubKey(".railmap");
            regKey.SetValue("", "railmapfile", RegistryValueKind.String);
            regKey.CreateSubKey(@"shell\open\command").SetValue("", Environment.ProcessPath + " \"%1\"");
            regKey.Close();
            RegistryKey regIcon = Registry.ClassesRoot.CreateSubKey(@"railmapfile\DefaultIcon");
            regIcon.SetValue("", Application.StartupPath + "fileicon.ico", RegistryValueKind.String);
            regIcon.Close();
        }
    }
}
