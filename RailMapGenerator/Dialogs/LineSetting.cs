using System;
using System.Windows.Forms;

namespace RailMapGenerator.Dialogs {
    public partial class LineSetting : Form {
        public Line line;

        public LineSetting(Line line = null) {
            InitializeComponent();
            this.line = line;
            if (this.line != null) {
                lineName.Text = this.line.name;
                panel1.BackColor = this.line.color;
            }
        }

        private void OK_Click(object sender, EventArgs e) {
            if (line == null)
                line = new Line(lineName.Text, panel1.BackColor);
            else {
                line.name = lineName.Text;
                line.color = panel1.BackColor;
            }
            Hide();
        }

        private void panel1_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.Color = panel1.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
                panel1.BackColor = cd.Color;
        }
    }
}
