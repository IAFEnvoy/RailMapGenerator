using System;
using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class LegendSetting : Form {
        private readonly RailMap map;

        public LegendSetting(RailMap map) {
            InitializeComponent();
            this.map = map;
            xOffset.Text = map.legend.location.X.ToString();
            yOffset.Text = map.legend.location.Y.ToString();
            rel.Text = map.legend.isHorizon ? "横向" : "纵向";
            count.Text = map.legend.count.ToString();
            RenderLegend();
        }

        private void RenderLegend() {
            if (int.TryParse(xOffset.Text, out int x) && int.TryParse(yOffset.Text, out int y) && int.TryParse(count.Text, out int c)) {
                map.legend.isHorizon = rel.Text == "横向";
                map.legend.location = new Point(x, y);
                map.legend.count = c;
                int w = (int)Math.Ceiling(1.0 * map.lines.Count / map.legend.count), h = map.legend.count;
                if (map.legend.isHorizon) (w, h) = (h, w);
                Bitmap bitmap = new Bitmap(w * 120 + 20, h * 20 + 15);
                Graphics g = Graphics.FromImage(bitmap);
                map.RenderLegend(g, new Point(0, 0), 1);
                pictureBox1.Image = bitmap;
            }
        }

        private void OnTextChange(object sender, EventArgs e) {
            if (Visible)
                RenderLegend();
        }
    }
}
