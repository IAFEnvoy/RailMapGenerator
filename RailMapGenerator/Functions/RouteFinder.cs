using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class RouteFinder : Form {
        private readonly RailMap railMap;
        public RouteFinder(RailMap railMap) {
            this.InitializeComponent();
            this.railMap = railMap;
            foreach(Station station in railMap.stations) {
                this.startStation.Items.Add(station.name);
                this.endStation.Items.Add(station.name);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.textBox1.Text = Route.GetShortestRoute(this.railMap.stations, this.railMap.lines, this.startStation.SelectedIndex, this.endStation.SelectedIndex);
        }
    }
}
