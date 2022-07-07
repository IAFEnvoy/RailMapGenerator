using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class Line {
        public string name;
        public List<int> stations = new List<int>();
        public List<StationStatus> status = new List<StationStatus>();
        public Color color;

        public Line(string name, Color color, params int[] stops) {
            this.name = name;
            this.color = color;
            foreach (int stop in stations) {
                stations.Add(stop);
                status.Add(StationStatus.Enable);
            }
        }
    }
}
