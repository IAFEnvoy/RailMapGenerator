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
                renderRadium.Text = stop.radium.ToString();
                enabled.Checked = stop.enable;
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(positionX.Text, out int x) && int.TryParse(positionY.Text, out int y)&&int.TryParse(renderRadium.Text,out int radium)) {
                if (stop == null)
                    stop = new Station(stopName.Text, x, y,enabled.Checked,radium);
                else {
                    stop.name = stopName.Text;
                    stop.location = new Point(x, y);
                    stop.enable = enabled.Checked;
                    stop.radium = radium;
                }
                Hide();
            } else
                MessageBox.Show("错误：X坐标或Y坐标或绘制半径不是数字");
        }
    }
}
