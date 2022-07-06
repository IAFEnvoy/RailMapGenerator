using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class MainForm : Form {
        private RailMap railMap = new RailMap();
        private string fileName = "";
        private readonly HotKeySetting setting = new HotKeySetting();

        public MainForm() {
            InitializeComponent();
            Setting.Load();
            if (Setting.INSTANCE.font == null)
                Setting.INSTANCE.font = Font;
            ReloadData(true, true, true, false);
            //add item to setting list
            setting.itemList.Add(添加站点ToolStripMenuItem);
            setting.itemList.Add(修改站点信息ToolStripMenuItem);
            setting.itemList.Add(删除选中站点ToolStripMenuItem);
            setting.itemList.Add(添加线路ToolStripMenuItem);
            setting.itemList.Add(修改线路信息ToolStripMenuItem);
            setting.itemList.Add(删除选中线路ToolStripMenuItem);
            setting.itemList.Add(拆分线路ToolStripMenuItem);
            setting.itemList.Add(将站点加入线路ToolStripMenuItem);
            setting.itemList.Add(从线路中删除站点ToolStripMenuItem);
            setting.itemList.Add(显示站点名ToolStripMenuItem);
            setting.itemList.Add(显示网格ToolStripMenuItem);
            setting.itemList.Add(站名字体ToolStripMenuItem);
            foreach (ToolStripMenuItem item in setting.itemList)
                if (Setting.INSTANCE.HotKeys.ContainsKey(item.Name))
                    item.ShortcutKeys = HotKeyUtil.GetKeyByString((string)Setting.INSTANCE.HotKeys[item.Name]).KeyData;
            // add setting strip
            ToolStripMenuItem item1 = new ToolStripMenuItem {
                Size = new Size(236, 26), Tag = Setting.INSTANCE.margin, 
                Text = Setting.INSTANCE.margin.Name + " : " + Setting.INSTANCE.margin.Value.ToString()
            };
            item1.Click += ModifyVariableClick;
            渲染设置ToolStripMenuItem.DropDownItems.Add(item1);
            ToolStripMenuItem item2 = new ToolStripMenuItem {
                Size = new Size(236, 26), Tag = Setting.INSTANCE.stopRadium,
                Text = Setting.INSTANCE.stopRadium.Name + " : " + Setting.INSTANCE.stopRadium.Value.ToString()
            };
            item2.Click += ModifyVariableClick;
            渲染设置ToolStripMenuItem.DropDownItems.Add(item2);
            ToolStripMenuItem item3 = new ToolStripMenuItem {
                Size = new Size(236, 26), Tag = Setting.INSTANCE.lineWidth,
                Text = Setting.INSTANCE.lineWidth.Name + " : " + Setting.INSTANCE.lineWidth.Value.ToString()
            };
            item3.Click += ModifyVariableClick;
            渲染设置ToolStripMenuItem.DropDownItems.Add(item3);
        }

        private void ModifyVariableClick(object sender, EventArgs e) {
            Setting.SettingObject obj = (Setting.SettingObject)((ToolStripMenuItem)sender).Tag;
            ModifyVariable form = new ModifyVariable();
            form.value = obj.Value;
            form.variableName.Text = obj.Name;
            form.ShowDialog();
            obj.Value = form.value;
            ((ToolStripMenuItem)sender).Text = obj.Name + " : " + obj.Value.ToString();
            form.Dispose();
            ReloadData(false, false, false);
        }

        private int ParseIndex(int origin, int count) {
            if (origin == -1) return -1;
            if (count == 0) return -1;
            if (origin == count) return origin - 1;
            return origin;
        }

        private void ReloadData(bool stops, bool lines, bool stopsOnLines, bool render = true) {
            if (railMap.IsEmpty()) {
                Stops.Items.Clear();
                Lines.Items.Clear();
                StopsOnLine.Items.Clear();
                Stops.Items.Add("没有站点");
                Lines.Items.Add("没有线路");
                StopsOnLine.Items.Add("未选择线路");
                return;
            }
            if (stops) {
                int index = Stops.SelectedIndex;
                Stops.Items.Clear();
                foreach (Station node in railMap.stops)
                    Stops.Items.Add(node.name);
                if (Stops.Items.Count == 0)
                    Stops.Items.Add("没有站点");
                Stops.SelectedIndex = ParseIndex(index, Stops.Items.Count);
            }
            if (lines) {
                int index = Lines.SelectedIndex;
                Lines.Items.Clear();
                foreach (Line line in railMap.lines)
                    Lines.Items.Add(line.name);
                if (Lines.Items.Count == 0)
                    Lines.Items.Add("没有线路");
                Lines.SelectedIndex = ParseIndex(index, Lines.Items.Count);
            }
            if (stopsOnLines) {
                StopsOnLine.Items.Clear();
                if (Lines.SelectedIndex >= 0) {
                    foreach (int stop in railMap.lines[Lines.SelectedIndex].stops)
                        StopsOnLine.Items.Add(railMap.stops[stop].name);
                    if (StopsOnLine.Items.Count == 0)
                        StopsOnLine.Items.Add("没有站点");
                } else
                    StopsOnLine.Items.Add("未选择线路");
            }
            if (render) {
                MapHorizonSB.Maximum = 0;
                MapHorizonSB.Enabled = false;
                MapVerticalSB.Maximum = 0;
                MapVerticalSB.Enabled = false;
                if (railMap.stops.Count > 0) {
                    float zoom = int.Parse(Zoom.Text.Replace('%', '\0')) / 100.0f;
                    Bitmap origin = railMap.RenderMap(zoom, 显示站点名ToolStripMenuItem.Checked, 显示网格ToolStripMenuItem.Checked);
                    map.Image = origin;
                    if (origin.Width > MapPanel.Width) {
                        MapHorizonSB.Maximum = (origin.Width - MapPanel.Width) / 10 + 1;
                        MapHorizonSB.Enabled = true;
                    }
                    if (origin.Height > MapPanel.Height) {
                        MapVerticalSB.Maximum = (origin.Height - MapPanel.Height) / 10 + 1;
                        MapVerticalSB.Enabled = true;
                    }
                } else
                    map.Image = new Bitmap(Setting.INSTANCE.margin.Value * 2, Setting.INSTANCE.margin.Value * 2);
                map.Location = new Point(0, 0);
            }
        }

        private void AddStop_Click(object sender, EventArgs e) {
            StopSetting form = new StopSetting();
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            if (form.stop != null)
                railMap.stops.Add(form.stop);
            form.Dispose();
            ReloadData(true, false, false);
        }

        private void AddLine_Click(object sender, EventArgs e) {
            LineSetting form = new LineSetting();
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            if (form.line != null)
                railMap.lines.Add(form.line);
            form.Dispose();
            ReloadData(false, true, false);
        }

        private void Lines_SelectedIndexChanged(object sender, EventArgs e) {
            if (Lines.SelectedIndex != -1)
                ReloadData(false, false, true);
        }

        private void AddStopToLine_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) {
                MessageBox.Show("请先选择站点");
                return;
            }
            if (Lines.SelectedIndex == -1) {
                MessageBox.Show("请先选择线路");
                return;
            }
            railMap.lines[Lines.SelectedIndex].stops.Add(Stops.SelectedIndex);
            ReloadData(false, false, true);
        }

        private void MoveUp_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex >= 1) {
                int index = StopsOnLine.SelectedIndex;
                (railMap.lines[Lines.SelectedIndex].stops[index], railMap.lines[Lines.SelectedIndex].stops[index - 1])
                    = (railMap.lines[Lines.SelectedIndex].stops[index - 1], railMap.lines[Lines.SelectedIndex].stops[index]);
                ReloadData(false, false, true);
                StopsOnLine.SelectedIndex = index - 1;
            }
        }

        private void MoveDown_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex >= 0 && StopsOnLine.SelectedIndex < StopsOnLine.Items.Count - 1) {
                int index = StopsOnLine.SelectedIndex;
                (railMap.lines[Lines.SelectedIndex].stops[index], railMap.lines[Lines.SelectedIndex].stops[index + 1])
                    = (railMap.lines[Lines.SelectedIndex].stops[index + 1], railMap.lines[Lines.SelectedIndex].stops[index]);
                ReloadData(false, false, true);
                StopsOnLine.SelectedIndex = index + 1;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    保存ToolStripMenuItem_Click(sender, e);
                if (result == DialogResult.Cancel)
                    return;
            }
            railMap = new RailMap();
            ReloadData(true, true, true);
            map.Image = new Bitmap(Setting.INSTANCE.margin.Value * 2, Setting.INSTANCE.margin.Value * 2);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fileName != "") {
                File.WriteAllText(fileName, JsonConvert.SerializeObject(railMap), Encoding.UTF8);
                FileStatus.Text = "成功保存至: " + fileName;
            } else
                另存为ToolStripMenuItem_Click(sender, e);
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog {
                Title = "保存", Filter = "*.railmap|*.railmap"
            };
            if (sfd.ShowDialog() == DialogResult.OK) {
                fileName = sfd.FileName;
                File.WriteAllText(fileName, JsonConvert.SerializeObject(railMap), Encoding.UTF8);
                FileStatus.Text = "成功保存至: " + sfd.FileName;
            }
            sfd.Dispose();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Title = "打开文件", Filter = "*.railmap|*.railmap"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                fileName = ofd.FileName;
                railMap = JsonConvert.DeserializeObject<RailMap>(File.ReadAllText(fileName, Encoding.UTF8));
                ReloadData(true, true, true);
                FileStatus.Text = "成功打开文件: " + ofd.FileName;
            }
            ofd.Dispose();
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog {
                Title = "导出", Filter = "*.png|*.png"
            };
            if (sfd.ShowDialog() == DialogResult.OK) {
                railMap.RenderMap(1, 显示站点名ToolStripMenuItem.Checked, 显示网格ToolStripMenuItem.Checked).Save(sfd.FileName);
                FileStatus.Text = "成功导出至: " + sfd.FileName;
            }
            sfd.Dispose();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            Setting.Save();
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) {
                    保存ToolStripMenuItem_Click(sender, e);
                    Environment.Exit(0);
                } else if (result == DialogResult.No)
                    Environment.Exit(0);
            } else Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Setting.Save();
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    保存ToolStripMenuItem_Click(sender, e);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else Environment.Exit(0);
            } else Environment.Exit(0);
        }

        private void Remove_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex == -1 || Lines.SelectedIndex == -1) return;
            railMap.lines[Lines.SelectedIndex].stops.RemoveAt(StopsOnLine.SelectedIndex);
            ReloadData(false, false, true);
        }

        private void RemoveStop_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            int index = Stops.SelectedIndex;
            foreach (Line line in railMap.lines) {
                line.stops.Remove(index);
                for (int i = 0; i < line.stops.Count; i++)
                    if (line.stops[i] > index)
                        line.stops[i]--;
            }
            railMap.stops.RemoveAt(index);
            ReloadData(true, false, true);
        }

        private void RemoveLine_Click(object sender, EventArgs e) {
            if (Lines.SelectedIndex == -1) return;
            railMap.lines.RemoveAt(Lines.SelectedIndex);
            ReloadData(false, true, true);
        }

        private void ModiftStop_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            StopSetting form = new StopSetting(railMap.stops[Stops.SelectedIndex]);
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            form.Dispose();
            ReloadData(true, false, false);
        }

        private void ModifyLine_Click(object sender, EventArgs e) {
            if (Lines.SelectedIndex == -1) return;
            LineSetting form = new LineSetting(railMap.lines[Lines.SelectedIndex]);
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            form.Dispose();
            ReloadData(false, true, true);
        }

        private void ModiftFont_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog {
                Font = Setting.INSTANCE.font
            };
            if (fd.ShowDialog() == DialogResult.OK)
                Setting.INSTANCE.font = fd.Font;
            fd.Dispose();
            ReloadData(false, false, false);
        }

        private void ZoomChange(object sender, EventArgs e) {
            Zoom.Text = ((ToolStripMenuItem)sender).Text;
            ReloadData(false, false, false);
        }

        private void MapHorizonSB_ValueChanged(object sender, EventArgs e) {
            map.Location = new Point(-MapHorizonSB.Value * 10, -MapVerticalSB.Value * 10);
        }

        private void MapVerticalSB_ValueChanged(object sender, EventArgs e) {
            map.Location = new Point(-MapHorizonSB.Value * 10, -MapVerticalSB.Value * 10);
        }

        private void SplitLine_Click(object sender, EventArgs e) {
            if (Lines.SelectedIndex == -1) return;
            LineSetting form1 = new LineSetting {
                Text = "拆分线路"
            };
            form1.ShowDialog();
            if (form1.line == null) return;
            SplitLine form2 = new SplitLine(railMap.lines[Lines.SelectedIndex], form1.line, railMap);
            form2.ShowDialog();
            ReloadData(false, true, true);
        }

        private void Check_Change(object sender, EventArgs e) {
            ReloadData(false, false, false);
        }

        private void 快捷键设置ToolStripMenuItem_Click(object sender, EventArgs e) {
            setting.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e) {
            About form = new About();
            form.ShowDialog();
            form.Dispose();
        }

        private void 支持ToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://afdian.net/@0218xingcheng");
        }

        private void 上移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            railMap.MoveAll(0, -50);
            ReloadData(false, false, false);
        }

        private void 下移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            railMap.MoveAll(0, 50);
            ReloadData(false, false, false);
        }

        private void 左移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            railMap.MoveAll(-50, 0);
            ReloadData(false, false, false);
        }

        private void 右移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            railMap.MoveAll(50, 0);
            ReloadData(false, false, false);
        }
    }
}
