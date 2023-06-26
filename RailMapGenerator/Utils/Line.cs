using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class Line : IRoutable {
        public string name;
        public List<int> stations = new();
        public List<bool> sectionEnabled = new();
        public Color color;
        public int lineWidth;

        public Line(string name, Color color, int lineWidth, params int[] stations) {
            this.name = name;
            this.color = color;
            this.lineWidth = lineWidth;
            foreach (int station in stations) {
                this.stations.Add(station);
                this.sectionEnabled.Add(true);
            }
        }

        public string GetName() {
            return this.name;
        }
    }
}
