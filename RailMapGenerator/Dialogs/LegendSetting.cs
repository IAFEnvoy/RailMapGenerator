using System;
using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class LegendSetting : Form {
        private readonly RailMap map;

        public LegendSetting(RailMap map) {
            this.InitializeComponent();
            this.map = map;
            this.xOffset.Text = this.map.legend.location.X.ToString();
            this.yOffset.Text = this.map.legend.location.Y.ToString();
            this.rel.Text = this.map.legend.isHorizon ? "横向" : "纵向";
            this.count.Text = this.map.legend.count.ToString();
            this.zoom.Text = Math.Round(this.map.legend.zoom * 100, 1).ToString() + "%";
            this.RenderLegend();
        }

        private void RenderLegend() {
            if (int.TryParse(this.xOffset.Text, out int x) && int.TryParse(this.yOffset.Text, out int y) && int.TryParse(this.count.Text, out int c)
                && float.TryParse(this.zoom.Text.Replace('%', '\0'), out float z)) {
                this.map.legend.isHorizon = this.rel.Text == "横向";
                this.map.legend.location = new Point(x, y);
                this.map.legend.count = c;
                this.map.legend.zoom = z / 100.0f;
                this.pictureBox1.Image = this.map.RenderLegend(1);
            }
        }

        private void OnTextChange(object sender, EventArgs e) {
            if (this.Visible)
                this.RenderLegend();
        }
    }
}
