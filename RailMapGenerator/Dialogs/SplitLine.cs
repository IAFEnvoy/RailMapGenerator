using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class SplitLine : Form {
        private readonly Line oriLine, newLine;
        private readonly RailMap map;

        public SplitLine(Line oriLine, Line newLine, RailMap map) {
            this.InitializeComponent();
            this.oriLine = oriLine;
            this.newLine = newLine;
            this.map = map;
            foreach (int i in this.oriLine.stations)
                this.Stops.Items.Add(this.map.stations[i].name);
        }

        private void Ok_Click(object sender, EventArgs e) {
            if (this.Stops.SelectedIndex == -1) return;
            for (int i = this.Stops.SelectedIndex; i < this.oriLine.stations.Count; i++) {
                this.newLine.stations.Add(this.oriLine.stations[i]);
                this.newLine.sectionEnabled.Add(this.oriLine.sectionEnabled[i]);
            }
            for (int i = this.oriLine.stations.Count - 1; i > this.Stops.SelectedIndex; i--) {
                this.oriLine.stations.RemoveAt(i);
                this.oriLine.sectionEnabled.RemoveAt(i);
            }
            this.oriLine.sectionEnabled.RemoveAt(this.Stops.SelectedIndex);
            this.map.lines.Add(this.newLine);
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
