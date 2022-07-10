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

        public MainForm() {
            InitializeComponent();
            controlPanel.Tag = this.Width - controlPanel.Left;
            ReloadData(true, true, true, false);
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
                foreach (Station node in railMap.stations)
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
                    foreach (int stop in railMap.lines[Lines.SelectedIndex].stations)
                        StopsOnLine.Items.Add(railMap.stations[stop].name);
                    if (StopsOnLine.Items.Count == 0)
                        StopsOnLine.Items.Add("没有站点");
                } else
                    StopsOnLine.Items.Add("未选择线路");
            }
            if (render) {
                int hsV = MapPanel.HorizontalScroll.Value, vsV = MapPanel.VerticalScroll.Value;
                MapPanel.AutoScroll = false;
                if (railMap.stations.Count > 0) {
                    float zoom = int.Parse(Zoom.Text.Replace('%', '\0')) / 100.0f;
                    map.Image = railMap.RenderMap(zoom, 显示站点名ToolStripMenuItem.Checked, 显示网格ToolStripMenuItem.Checked); ;
                } else
                    map.Image = new Bitmap(railMap.margin * 2, railMap.margin * 2);
                map.Location = new Point(0, 0);
                MapPanel.AutoScroll = true;
                MapPanel.HorizontalScroll.Value = hsV;
                MapPanel.VerticalScroll.Value = vsV;
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
                railMap.stations.Add(form.stop);
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
            ReloadData(false, true, false);
        }

        private void Lines_SelectedIndexChanged(object sender, EventArgs e) {
            if (Lines.SelectedIndex != -1)
                ReloadData(false, false, true);
        }

        private void AddStopToLine_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) {
                MessageBox.Show("请先选择站点", "线路图生成器");
                return;
            }
            if (Lines.SelectedIndex == -1) {
                MessageBox.Show("请先选择线路", "线路图生成器");
                return;
            }
            railMap.lines[Lines.SelectedIndex].stations.Add(Stops.SelectedIndex);
            railMap.lines[Lines.SelectedIndex].sectionEnabled.Add(true);
            ReloadData(false, false, true);
        }

        private void MoveUp_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex >= 1) {
                int index = StopsOnLine.SelectedIndex;
                (railMap.lines[Lines.SelectedIndex].stations[index], railMap.lines[Lines.SelectedIndex].stations[index - 1])
                    = (railMap.lines[Lines.SelectedIndex].stations[index - 1], railMap.lines[Lines.SelectedIndex].stations[index]);
                (railMap.lines[Lines.SelectedIndex].sectionEnabled[index], railMap.lines[Lines.SelectedIndex].sectionEnabled[index - 1])
                    = (railMap.lines[Lines.SelectedIndex].sectionEnabled[index - 1], railMap.lines[Lines.SelectedIndex].sectionEnabled[index]);
                ReloadData(false, false, true);
                StopsOnLine.SelectedIndex = index - 1;
            }
        }

        private void MoveDown_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex >= 0 && StopsOnLine.SelectedIndex < StopsOnLine.Items.Count - 1) {
                int index = StopsOnLine.SelectedIndex;
                (railMap.lines[Lines.SelectedIndex].stations[index], railMap.lines[Lines.SelectedIndex].stations[index + 1])
                    = (railMap.lines[Lines.SelectedIndex].stations[index + 1], railMap.lines[Lines.SelectedIndex].stations[index]);
                (railMap.lines[Lines.SelectedIndex].sectionEnabled[index], railMap.lines[Lines.SelectedIndex].sectionEnabled[index + 1])
                    = (railMap.lines[Lines.SelectedIndex].sectionEnabled[index + 1], railMap.lines[Lines.SelectedIndex].sectionEnabled[index]);
                ReloadData(false, false, true);
                StopsOnLine.SelectedIndex = index + 1;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    保存ToolStripMenuItem_Click(sender, e);
                if (result == DialogResult.Cancel)
                    return;
            }
            railMap = new RailMap();
            ReloadData(true, true, true);
            map.Image = new Bitmap(railMap.margin * 2, railMap.margin * 2);
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
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) {
                    保存ToolStripMenuItem_Click(sender, e);
                    Environment.Exit(0);
                } else if (result == DialogResult.No)
                    Environment.Exit(0);
            } else Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    保存ToolStripMenuItem_Click(sender, e);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else Environment.Exit(0);
            } else Environment.Exit(0);
        }

        private void Remove_Click(object sender, EventArgs e) {
            if (StopsOnLine.SelectedIndex == -1 || Lines.SelectedIndex == -1) return;
            railMap.lines[Lines.SelectedIndex].stations.RemoveAt(StopsOnLine.SelectedIndex);
            railMap.lines[Lines.SelectedIndex].sectionEnabled.RemoveAt(StopsOnLine.SelectedIndex);
            ReloadData(false, false, true);
        }

        private void RemoveStop_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            int index = Stops.SelectedIndex;
            foreach (Line line in railMap.lines) {
                while (line.stations.Contains(index)) {
                    int i = line.stations.IndexOf(index);
                    line.stations.RemoveAt(i);
                    line.sectionEnabled.RemoveAt(i);
                }
                for (int i = 0; i < line.stations.Count; i++)
                    if (line.stations[i] > index)
                        line.stations[i]--;
            }
            railMap.stations.RemoveAt(index);
            ReloadData(true, false, true);
        }

        private void RemoveLine_Click(object sender, EventArgs e) {
            if (Lines.SelectedIndex == -1) return;
            railMap.lines.RemoveAt(Lines.SelectedIndex);
            ReloadData(false, true, true);
        }

        private void ModiftStop_Click(object sender, EventArgs e) {
            if (Stops.SelectedIndex == -1) return;
            StopSetting form = new StopSetting(railMap.stations[Stops.SelectedIndex]);
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
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
            ReloadData(false, true, true);
        }

        private void ModiftFont_Click(object sender, EventArgs e) {
            FontDialog fd = new FontDialog {
                Font = railMap.font
            };
            if (fd.ShowDialog() == DialogResult.OK)
                railMap.font = fd.Font;
            ReloadData(false, false, false);
        }

        private void ZoomChange(object sender, EventArgs e) {
            Zoom.Text = ((ToolStripMenuItem)sender).Text;
            ReloadData(false, false, false);
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

        private void MainForm_Resize(object sender, EventArgs e) {
            if (controlPanel.Tag == null) return;
            controlPanel.Left = this.Width - (int)controlPanel.Tag;
            MapPanel.Width = controlPanel.Left - 10;
            MapPanel.Height = status.Top - menu.Height - 10;
            ReloadData(false, false, false);
        }

        private void ModifyStatus_Click(object sender, EventArgs e) {
            if (Lines.SelectedIndex == -1) return;
            SectionSetting form = new SectionSetting(railMap, railMap.lines[Lines.SelectedIndex]);
            form.ShowDialog();
            ReloadData(false, false, false);
        }

        private void StarMeOnGithubToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/IAFEnvoy/RailMapGenerator");
        }

        private void 图例设置ToolStripMenuItem_Click(object sender, EventArgs e) {
            LegendSetting form = new LegendSetting(railMap);
            form.ShowDialog();
        }
    }
}
