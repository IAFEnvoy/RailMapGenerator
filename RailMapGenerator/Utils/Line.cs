using System.Collections.Generic;
using System.Drawing;

namespace RailMapGenerator {
    public class Line {
        public string name;
        public List<int> stops = new List<int>();
        public Color color;

        public Line(string name, Color color, params int[] stops) {
            this.name = name;
            this.color = color;
            foreach (int stop in stops)
                this.stops.Add(stop);
        }
    }
}
