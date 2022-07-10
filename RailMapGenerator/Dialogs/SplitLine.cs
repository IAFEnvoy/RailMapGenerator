using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class SplitLine : Form {
        private readonly Line oriLine, newLine;
        private readonly RailMap map;

        public SplitLine(Line oriLine, Line newLine, RailMap map) {
            InitializeComponent();
            this.oriLine = oriLine;
            this.newLine = newLine;
            this.map = map;
            foreach (int i in oriLine.stations)
                Stops.Items.Add(map.stations[i].name);
        }

        private void Ok_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            for (int i = Stops.SelectedIndex; i < oriLine.stations.Count; i++)
                newLine.stations.Add(oriLine.stations[i]);
            for (int i = oriLine.stations.Count - 1; i > Stops.SelectedIndex; i--)
                oriLine.stations.RemoveAt(i);
            map.lines.Add(newLine);
            Hide();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
