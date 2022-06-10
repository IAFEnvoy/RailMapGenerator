using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class HotKeySetting : Form {
        public List<ToolStripMenuItem> itemList = new List<ToolStripMenuItem>();

        public HotKeySetting() {
            InitializeComponent();
        }

        private void HotKeyInput_KeyDown(object sender, KeyEventArgs e) {
            e.Handled = true;
            try {
                new ToolStripMenuItem() { ShortcutKeys = e.KeyData };
                HotKeyInput.Text = HotKeyUtil.GetStringByKey(e);
            } catch {
                HotKeyInput.Text = "Invalid HotKey";
            }
        }

        private void HotKeyInput_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void HotKeyTargets_SelectedIndexChanged(object sender, EventArgs e) {
            if (HotKeyTargets.SelectedIndex == -1) return;
            HotKeyInput.Text = HotKeyUtil.GetStringByKey(new KeyEventArgs(itemList[HotKeyTargets.SelectedIndex].ShortcutKeys));
            HotKeyInput.Focus();
        }

        private void Clear_Click(object sender, EventArgs e) {
            HotKeyInput.Text = "";
        }

        private void OK_Click(object sender, EventArgs e) {
            if (HotKeyInput.Text != "Invalid HotKey" && HotKeyTargets.SelectedIndex != -1) {
                itemList[HotKeyTargets.SelectedIndex].ShortcutKeys = HotKeyUtil.GetKeyByString(HotKeyInput.Text).KeyData;
                HotKeySetting_Load(null, null);
            }
        }

        private void HotKeySetting_Load(object sender, EventArgs e) {
            HotKeyTargets.Items.Clear();
            foreach (ToolStripMenuItem item in itemList)
                HotKeyTargets.Items.Add(item.Text + " : " + HotKeyUtil.GetStringByKey(new KeyEventArgs(item.ShortcutKeys)));
        }
    }
}
