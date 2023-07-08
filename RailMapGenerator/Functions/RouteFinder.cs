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
            int stationWeight = 0, transferWeight = 0;
            if (this.radioButton1.Checked) {
                stationWeight = 1;
                transferWeight = 0;
            } else if (this.radioButton2.Checked) {
                stationWeight = 1;
                transferWeight = 1;
            } else if (this.radioButton3.Checked) {
                stationWeight = 1;
                transferWeight = 10;
            } else return;
            this.routeList.Items.Clear();
            this.routeList.Tag = null;
            List<List<IRoutable>> ans = Route.GetShortestPath(this.railMap, this.startStation.SelectedIndex, this.endStation.SelectedIndex, stationWeight, transferWeight, this.checkBox1.Checked);
            if (ans.Count == 0) this.routeList.Items.Add("未找到可行线路");
            else foreach (List<IRoutable> s in ans) {
                    List<string> newList = new();
                    s.ForEach(i => newList.Add(i.GetName()));
                    this.routeList.Items.Add(string.Join('-', newList));
                    this.routeList.Tag = ans;
                }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (this.routeList.SelectedIndex != -1)
                Clipboard.SetText((string)this.routeList.SelectedItem);
        }

        private void routeList_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.routeList.SelectedIndex == -1) return;

        }
    }
}
