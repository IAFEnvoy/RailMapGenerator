using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class LineSetting : Form {
        public Line line;

        public LineSetting(Line line = null) {
            InitializeComponent();
            this.line = line;
            if (this.line != null) {
                lineName.Text = this.line.name;
                panel1.BackColor = this.line.color;
                lineWidth.Text = line.lineWidth.ToString();
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (int.TryParse(lineWidth.Text, out int width))
                if (line == null)
                    line = new Line(lineName.Text, panel1.BackColor, width);
                else {
                    line.name = lineName.Text;
                    line.color = panel1.BackColor;
                    line.lineWidth = width;
                }
            else
                MessageBox.Show("绘制宽度不是数字");
            Hide();
        }

        private void Panel1_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.Color = panel1.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                panel1.BackColor = cd.Color;
        }
    }
}
