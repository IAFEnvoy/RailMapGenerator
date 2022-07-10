using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class SectionSetting : Form {
        private readonly RailMap map;
        private readonly Line line;
        public SectionSetting(RailMap map, Line line) {
            InitializeComponent();
            this.line = line;
            this.map = map;
            LoadListBox();
        }

        private void LoadListBox() {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            for (int i = 0; i < line.stations.Count - 1; i++) {
                string text = (line.sectionEnabled[i] ? "已开通  " : "未开通  ") + map.stations[line.stations[i]].name + " - " + map.stations[line.stations[i + 1]].name;
                listBox1.Items.Add(text);
            }
            listBox1.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            line.sectionEnabled[index] = true;
            LoadListBox();
        }

        private void button2_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            line.sectionEnabled[index] = false;
            LoadListBox();
        }
    }
}
