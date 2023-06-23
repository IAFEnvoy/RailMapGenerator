using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class LineSetting : Form {
        public Line line;

        public LineSetting(Line line = null) {
            this.InitializeComponent();
            this.line = line;
            if (this.line != null) {
                this.lineName.Text = this.line.name;
                this.panel1.BackColor = this.line.color;
                this.lineWidth.Text = this.line.lineWidth.ToString();
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(this.lineWidth.Text, out int width))
                if (this.line == null)
                    this.line = new Line(this.lineName.Text, this.panel1.BackColor, width);
                else {
                    this.line.name = this.lineName.Text;
                    this.line.color = this.panel1.BackColor;
                    this.line.lineWidth = width;
                }
            else
                MessageBox.Show("绘制参数不是数字", "线路图生成器", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Hide();
        }

        private void Panel1_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.Color = this.panel1.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                this.panel1.BackColor = cd.Color;
        }
    }
}
