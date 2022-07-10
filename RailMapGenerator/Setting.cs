using Newtonsoft.Json;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RailMapGenerator {
    internal class Setting {
        [JsonIgnore]
        public static Setting INSTANCE = new Setting();
        [JsonIgnore]
        public static string configPath = Application.StartupPath + @"\Settings.json";
        public Font font = null;
        public SettingObject margin = new SettingObject("边缘宽度", 20);
        public Hashtable HotKeys = new Hashtable();

        public static void Load() {
            if (!File.Exists(configPath)) return;
            INSTANCE = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(configPath,Encoding.UTF8));
        }

        public static void Save() {
            File.WriteAllText(configPath, JsonConvert.SerializeObject(INSTANCE),Encoding.UTF8);
        }

        public class SettingObject {
            public string Name;
            public int Value;

            public SettingObject(string name, int value) {
                Name = name;
                Value = value;
            }
        }
    }
}
