using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class StopSetting : Form {
        public Node stop;

        public StopSetting(Node stop = null) {
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
                    stop = new Node(stopName.Text, x, y);
                else {
                    stop.name = stopName.Text;
                    stop.location = new System.Drawing.Point(x, y);
                }
                Hide();
            } else
                MessageBox.Show("错误：X坐标或Y坐标不是数字");
        }
    }
}
