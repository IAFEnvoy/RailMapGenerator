using System;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class ModifyVariable : Form {
        public int value;

        public ModifyVariable() {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e) {
            value = int.Parse(variableValue.Text);
            Hide();
        }

        private void VariableValue_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
            if (e.KeyChar == '\b') e.Handled = false;
        }

        private void ModifyVariable_Load(object sender, EventArgs e) {
            variableValue.Text = value.ToString();
        }
    }
}
