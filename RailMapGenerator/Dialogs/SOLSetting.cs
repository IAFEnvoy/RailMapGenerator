using System;
using System.Windows.Forms;

namespace RailMapGenerator{
    public partial class SOLSetting : Form {//Station On Line Setting Form
        private readonly RailMap map;
        private readonly Line line;
        public SOLSetting(RailMap map, Line line) {
            InitializeComponent();
            this.line = line;
            this.map = map;
            LoadListBox();
        }

        private void LoadListBox() {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            for (int i = 0; i < line.stations.Count; i++) {
                string text = map.stations[line.stations[i]].name;
                switch (line.status[i]) {
                    case StationStatus.Enable: { text = "已开通 " + text; break; }
                    case StationStatus.Disable: { text = "未通车 " + text; break; }
                    case StationStatus.Cross: { text = "不停靠 " + text; break; }
                }
                listBox1.Items.Add(text);
            }
            listBox1.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            line.status[index] = StationStatus.Enable;
            LoadListBox();
        }

        private void button2_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            line.status[index] = StationStatus.Disable;
            LoadListBox();
        }

        private void button3_Click(object sender, EventArgs e) {
            int index = listBox1.SelectedIndex;
            if (index == -1) return;
            line.status[index] = StationStatus.Cross;
            LoadListBox();
        }
    }
}
