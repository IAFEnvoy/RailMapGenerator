using System;
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
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(positionX.Text, out int x) && int.TryParse(positionY.Text, out int y)) {
                if (stop == null)
                    stop = new Station(stopName.Text, x, y, enable.Checked);
                else {
                    stop.name = stopName.Text;
                    stop.location = new System.Drawing.Point(x, y);
                    stop.enable = enable.Checked;
                }
                Hide();
            } else
                MessageBox.Show("错误：X坐标或Y坐标不是数字");
        }
    }
}
