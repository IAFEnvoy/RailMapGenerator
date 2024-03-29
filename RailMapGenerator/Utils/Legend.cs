﻿using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public class Legend {
        public Point location;
        public bool isHorizon;
        public int count;
        public Font font = Control.DefaultFont;
        public float zoom = 1;

        public Legend(int x = 0, int y = 0, bool isHorizon = false, int count = 2) {
            this.location = new Point(x, y);
            this.isHorizon = isHorizon;
            this.count = count;
        }
    }
}
