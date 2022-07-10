using System;
using System.Drawing;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class StopSetting : Form {
        public Station stop;

        public StopSetting(Station stop = null) {
            InitializeComponent();
            this.stop = stop;
            if (this.stop != null) {
                stopName.Text = this.stop.name;
                positionX.Text = this.stop.location.X.ToString();
                positionY.Text = this.stop.location.Y.ToString();
                renderRadium.Text = this.stop.radium.ToString();
                enabled.Checked = this.stop.enable;
                xOffset.Text = (this.stop.textOffsetX - this.stop.location.X).ToString();
                yOffset.Text = (this.stop.textOffsetY - this.stop.location.Y).ToString();
                autoText.Checked = this.stop.autoTextPos;
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(positionX.Text, out int x) && int.TryParse(positionY.Text, out int y) && int.TryParse(renderRadium.Text, out int radium)
                && double.TryParse(xOffset.Text, out double offsetX) && double.TryParse(yOffset.Text, out double offsetY)) {
                if (stop == null) {
                    stop = new Station(stopName.Text, x, y, enabled.Checked, radium) {
                        autoTextPos = autoText.Checked, textOffsetX = offsetX, textOffsetY = offsetY
                    };
                }
                else {
                    stop.name = stopName.Text;
                    stop.location = new Point(x, y);
                    stop.enable = enabled.Checked;
                    stop.radium = radium;
                    stop.autoTextPos = autoText.Checked;
                    stop.textOffsetX = offsetX + stop.location.X;
                    stop.textOffsetY = offsetY + stop.location.Y;
                }
                Hide();
            }
            else
                MessageBox.Show("某个应该为数字的参数不是数字", "线路图生成器", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisableAutoText(object sender, EventArgs e) {
            autoText.Checked = false;
        }
    }
}
