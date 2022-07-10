using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class LegendSetting : Form {
        private readonly RailMap map;
        public LegendSetting(RailMap map) {
            InitializeComponent();
            this.map = map;
            switch (map.legend.locate) {
                case Legend.Locate.TopLeft: { dir.Text = "左上";break; }
                case Legend.Locate.TopRight: { dir.Text = "右上";break; }
                case Legend.Locate.BottomLeft: { dir.Text = "左下";break; }
                case Legend.Locate.BottomRight: { dir.Text = "右下";break; }
            }
            rel.Text = map.legend.isHorizon ? "横向" : "纵向";
            count.Text = map.legend.count.ToString();
            RenderLegend();
        }

        private void Render_Click(object sender, EventArgs e) {
            RenderLegend();
        }

        private void RenderLegend() {
            switch (dir.Text) {
                case "左上": { map.legend.locate = Legend.Locate.TopLeft; break; }
                case "右上": { map.legend.locate = Legend.Locate.TopRight; break; }
                case "左下": { map.legend.locate = Legend.Locate.BottomLeft; break; }
                case "右下": { map.legend.locate = Legend.Locate.BottomRight; break; }
                default: { throw new Exception("错误的Locate变量"); }
            }
            map.legend.isHorizon = rel.Text == "横向";
            if (int.TryParse(count.Text, out map.legend.count)) {
                pictureBox1.Image = map.RenderLegend();
            } else {
                MessageBox.Show("错误：个数不是数字");
            }
        }

        private void OnTextChange(object sender, EventArgs e) {
            RenderLegend();
        }
    }
}
