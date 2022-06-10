using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class SplitLine : Form {
        Line oriLine, newLine;
        RailMap map;

        public SplitLine(Line oriLine, Line newLine, RailMap map) {
            InitializeComponent();
            this.oriLine = oriLine;
            this.newLine = newLine;
            this.map = map;
            foreach (int i in oriLine.stops)
                Stops.Items.Add(map.stops[i].name);
        }

        private void Ok_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            for (int i = Stops.SelectedIndex; i < oriLine.stops.Count; i++)
                newLine.stops.Add(oriLine.stops[i]);
            for (int i = oriLine.stops.Count - 1; i > Stops.SelectedIndex; i--)
                oriLine.stops.RemoveAt(i);
            map.lines.Add(newLine);
            Hide();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Hide();
        }
    }
}
