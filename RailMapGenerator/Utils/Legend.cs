using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailMapGenerator {
    public class Legend {
        public Locate locate;
        public bool isHorizon;
        public int count;
        public Font font = Control.DefaultFont;

        public Legend(Locate locate = Locate.BottomRight, bool isHorizon = false, int count = 2) {
            this.locate = locate;
            this.isHorizon = isHorizon;
            this.count = count;
        }

        public enum Locate {
            TopLeft, TopRight, BottomLeft, BottomRight
        }
    }
}
