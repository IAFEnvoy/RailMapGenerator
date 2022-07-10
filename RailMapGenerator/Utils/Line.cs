using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class Line {
        public string name;
        public List<int> stations = new List<int>();
        public List<bool> sectionEnabled = new List<bool>();
        public Color color;
        public int lineWidth;

        public Line(string name, Color color, int lineWidth, params int[] stations) {
            this.name = name;
            this.color = color;
            this.lineWidth = lineWidth;
            foreach (int station in stations) {
                this.stations.Add(station);
                sectionEnabled.Add(true);
            }
        }
    }
}
