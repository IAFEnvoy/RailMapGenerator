using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class SectionSetting : Form {
        private readonly RailMap map;
        private readonly Line line;
        public SectionSetting(RailMap map, Line line) {
            this.InitializeComponent();
            this.line = line;
            this.map = map;
            this.LoadListBox();
        }

        private void LoadListBox() {
            int index = this.listBox1.SelectedIndex;
            this.listBox1.Items.Clear();
            for (int i = 0; i < this.line.stations.Count - 1; i++) {
                string text = (this.line.sectionEnabled[i] ? "已开通  " : "未开通  ") + this.map.stations[this.line.stations[i]].name + " - " + this.map.stations[this.line.stations[i + 1]].name;
                this.listBox1.Items.Add(text);
            }
            this.listBox1.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e) {
            int index = this.listBox1.SelectedIndex;
            if (index == -1) return;
            this.line.sectionEnabled[index] = true;
            this.LoadListBox();
        }

        private void button2_Click(object sender, EventArgs e) {
            int index = this.listBox1.SelectedIndex;
            if (index == -1) return;
            this.line.sectionEnabled[index] = false;
            this.LoadListBox();
        }
    }
}
