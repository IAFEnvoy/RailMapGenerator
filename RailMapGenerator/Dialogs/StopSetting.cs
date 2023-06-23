using System;
using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class StopSetting : Form {
        public Station stop;

        public StopSetting(Station stop = null) {
            this.InitializeComponent();
            this.stop = stop;
            if (this.stop != null) {
                this.stopName.Text = this.stop.name;
                this.positionX.Text = this.stop.location.X.ToString();
                this.positionY.Text = this.stop.location.Y.ToString();
                this.renderRadium.Text = this.stop.radium.ToString();
                this.enabled.Checked = this.stop.enable;
                this.xOffset.Text = (this.stop.textOffsetX - this.stop.location.X).ToString();
                this.yOffset.Text = (this.stop.textOffsetY - this.stop.location.Y).ToString();
                this.autoText.Checked = this.stop.autoTextPos;
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(this.positionX.Text, out int x) && int.TryParse(this.positionY.Text, out int y) && int.TryParse(this.renderRadium.Text, out int radium)
                && double.TryParse(this.xOffset.Text, out double offsetX) && double.TryParse(this.yOffset.Text, out double offsetY)) {
                if (this.stop == null) {
                    this.stop = new(this.stopName.Text, x, y, this.enabled.Checked, radium) {
                        autoTextPos = this.autoText.Checked, textOffsetX = offsetX, textOffsetY = offsetY
                    };
                } else {
                    this.stop.name = this.stopName.Text;
                    this.stop.location = new(x, y);
                    this.stop.enable = this.enabled.Checked;
                    this.stop.radium = radium;
                    this.stop.autoTextPos = this.autoText.Checked;
                    this.stop.textOffsetX = offsetX + this.stop.location.X;
                    this.stop.textOffsetY = offsetY + this.stop.location.Y;
                }
                this.Hide();
            } else
                MessageBox.Show("某个应该为数字的参数不是数字", "线路图生成器", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisableAutoText(object sender, EventArgs e) {
            this.autoText.Checked = false;
        }
    }
}
