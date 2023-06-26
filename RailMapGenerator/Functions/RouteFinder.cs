using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class RouteFinder : Form {
        private readonly RailMap railMap;
        public RouteFinder(RailMap railMap) {
            this.InitializeComponent();
            this.railMap = railMap;
            foreach (Station station in railMap.stations) {
                this.startStation.Items.Add(station.name);
                this.endStation.Items.Add(station.name);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.textBox1.Text = "";
            List<List<IRoutable>> ans = Route.GetShortestPath(this.railMap, this.startStation.SelectedIndex, this.endStation.SelectedIndex, 1, 1);
            if (ans.Count == 0) this.textBox1.Text = "未找到可行线路";
            else
                foreach (List<IRoutable> s in ans) {
                    List<string> newList = new();
                    s.ForEach(i => newList.Add(i.GetName()));
                    this.textBox1.Text += string.Join('-', newList) + "\r\n";
                }
        }
    }
}
