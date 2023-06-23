using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RailMapGenerator {
    public partial class MainForm : Form {
        private RailMap railMap = new();
        private string fileName = "";

        public MainForm() {
            this.InitializeComponent();
            this.controlPanel.Tag = this.Width - this.controlPanel.Left;
            this.ReloadData(true, true, true, false);
        }

        private int ParseIndex(int origin, int count) {
            if (origin == -1) return -1;
            if (count == 0) return -1;
            if (origin == count) return origin - 1;
            return origin;
        }

        private void ReloadData(bool stops, bool lines, bool stopsOnLines, bool render = true) {
            if (this.railMap.IsEmpty()) {
                this.Stops.Items.Clear();
                this.Lines.Items.Clear();
                this.StopsOnLine.Items.Clear();
                this.Stops.Items.Add("没有站点");
                this.Lines.Items.Add("没有线路");
                this.StopsOnLine.Items.Add("未选择线路");
                return;
            }
            if (stops) {
                int index = this.Stops.SelectedIndex;
                this.Stops.Items.Clear();
                foreach (Station node in this.railMap.stations)
                    this.Stops.Items.Add(node.name);
                if (this.Stops.Items.Count == 0)
                    this.Stops.Items.Add("没有站点");
                this.Stops.SelectedIndex = this.ParseIndex(index, this.Stops.Items.Count);
            }
            if (lines) {
                int index = this.Lines.SelectedIndex;
                this.Lines.Items.Clear();
                foreach (Line line in this.railMap.lines)
                    this.Lines.Items.Add(line.name);
                if (this.Lines.Items.Count == 0)
                    this.Lines.Items.Add("没有线路");
                this.Lines.SelectedIndex = this.ParseIndex(index, this.Lines.Items.Count);
            }
            if (stopsOnLines) {
                this.StopsOnLine.Items.Clear();
                if (this.Lines.SelectedIndex >= 0) {
                    foreach (int stop in this.railMap.lines[this.Lines.SelectedIndex].stations)
                        this.StopsOnLine.Items.Add(this.railMap.stations[stop].name);
                    if (this.StopsOnLine.Items.Count == 0)
                        this.StopsOnLine.Items.Add("没有站点");
                }
                else
                    this.StopsOnLine.Items.Add("未选择线路");
            }
            if (render) {
                int hsV = this.MapPanel.HorizontalScroll.Value, vsV = this.MapPanel.VerticalScroll.Value;
                this.MapPanel.AutoScroll = false;
                if (this.railMap.stations.Count > 0) {
                    float zoom = int.Parse(this.Zoom.Text.Replace('%', '\0')) / 100.0f;
                    this.map.Image = this.railMap.RenderMap(zoom, this.显示站点名ToolStripMenuItem.Checked, this.显示网格ToolStripMenuItem.Checked, this.显示图例ToolStripMenuItem.Checked);
                }
                else
                    this.map.Image = new Bitmap(this.railMap.margin * 2, this.railMap.margin * 2);
                this.map.Location = new(0, 0);
                this.MapPanel.AutoScroll = true;
                this.MapPanel.HorizontalScroll.Value = hsV;
                this.MapPanel.VerticalScroll.Value = vsV;
            }
        }

        private void AddStop_Click(object sender, EventArgs e) {
            StopSetting form = new();
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            if (form.stop != null)
                this.railMap.stations.Add(form.stop);
            this.ReloadData(true, false, false);
        }

        private void AddLine_Click(object sender, EventArgs e) {
            LineSetting form = new();
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            if (form.line != null)
                this.railMap.lines.Add(form.line);
            this.ReloadData(false, true, false);
        }

        private void Lines_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex != -1)
                this.ReloadData(false, false, true);
        }

        private void AddStopToLine_Click(object sender, EventArgs e) {
            if (this.Stops.SelectedIndex == -1) {
                MessageBox.Show("请先选择站点", "线路图生成器");
                return;
            }
            if (this.Lines.SelectedIndex == -1) {
                MessageBox.Show("请先选择线路", "线路图生成器");
                return;
            }
            this.railMap.lines[this.Lines.SelectedIndex].stations.Add(this.Stops.SelectedIndex);
            this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled.Add(true);
            this.ReloadData(false, false, true);
        }

        private void MoveUp_Click(object sender, EventArgs e) {
            if (this.StopsOnLine.SelectedIndex >= 1) {
                int index = this.StopsOnLine.SelectedIndex;
                (this.railMap.lines[this.Lines.SelectedIndex].stations[index], this.railMap.lines[this.Lines.SelectedIndex].stations[index - 1])
                    = (this.railMap.lines[this.Lines.SelectedIndex].stations[index - 1], this.railMap.lines[this.Lines.SelectedIndex].stations[index]);
                (this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index], this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index - 1])
                    = (this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index - 1], this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index]);
                this.ReloadData(false, false, true);
                this.StopsOnLine.SelectedIndex = index - 1;
            }
        }

        private void MoveDown_Click(object sender, EventArgs e) {
            if (this.StopsOnLine.SelectedIndex >= 0 && this.StopsOnLine.SelectedIndex < this.StopsOnLine.Items.Count - 1) {
                int index = this.StopsOnLine.SelectedIndex;
                (this.railMap.lines[this.Lines.SelectedIndex].stations[index], this.railMap.lines[this.Lines.SelectedIndex].stations[index + 1])
                    = (this.railMap.lines[this.Lines.SelectedIndex].stations[index + 1], this.railMap.lines[this.Lines.SelectedIndex].stations[index]);
                (this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index], this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index + 1])
                    = (this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index + 1], this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled[index]);
                this.ReloadData(false, false, true);
                this.StopsOnLine.SelectedIndex = index + 1;
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!this.railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    this.保存ToolStripMenuItem_Click(sender, e);
                if (result == DialogResult.Cancel)
                    return;
            }
            this.railMap = new();
            this.ReloadData(true, true, true);
            this.map.Image = new Bitmap(this.railMap.margin * 2, this.railMap.margin * 2);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.fileName != "") {
                File.WriteAllText(this.fileName, JsonConvert.SerializeObject(this.railMap), Encoding.UTF8);
                this.FileStatus.Text = "成功保存至: " + this.fileName;
            }
            else
                this.另存为ToolStripMenuItem_Click(sender, e);
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new (){
                Title = "保存", Filter = "*.railmap|*.railmap"
            };
            if (sfd.ShowDialog() == DialogResult.OK) {
                this.fileName = sfd.FileName;
                File.WriteAllText(this.fileName, JsonConvert.SerializeObject(this.railMap), Encoding.UTF8);
                this.FileStatus.Text = "成功保存至: " + sfd.FileName;
            }
            sfd.Dispose();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new () {
                Title = "打开文件", Filter = "*.railmap|*.railmap"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                this.fileName = ofd.FileName;
                this.railMap = JsonConvert.DeserializeObject<RailMap>(File.ReadAllText(this.fileName, Encoding.UTF8));
                this.ReloadData(true, true, true);
                this.FileStatus.Text = "成功打开文件: " + ofd.FileName;
            }
            ofd.Dispose();
        }

        private void 导出ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new () {
                Title = "导出", Filter = "*.png|*.png"
            };
            if (sfd.ShowDialog() == DialogResult.OK) {
                float zoom = int.Parse(this.Zoom.Text.Replace('%', '\0')) / 100.0f;
                this.railMap.RenderMap(zoom, this.显示站点名ToolStripMenuItem.Checked, this.显示网格ToolStripMenuItem.Checked, this.显示图例ToolStripMenuItem.Checked).Save(sfd.FileName);
                this.FileStatus.Text = "成功导出至: " + sfd.FileName;
            }
            sfd.Dispose();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!this.railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes) {
                    this.保存ToolStripMenuItem_Click(sender, e);
                    Environment.Exit(0);
                }
                else if (result == DialogResult.No)
                    Environment.Exit(0);
            }
            else Environment.Exit(0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!this.railMap.IsEmpty()) {
                var result = MessageBox.Show("是否保存当前内容？", "线路图生成器", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    this.保存ToolStripMenuItem_Click(sender, e);
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void Remove_Click(object sender, EventArgs e) {
            if (this.StopsOnLine.SelectedIndex == -1 || this.Lines.SelectedIndex == -1) return;
            this.railMap.lines[this.Lines.SelectedIndex].stations.RemoveAt(this.StopsOnLine.SelectedIndex);
            this.railMap.lines[this.Lines.SelectedIndex].sectionEnabled.RemoveAt(this.StopsOnLine.SelectedIndex);
            this.ReloadData(false, false, true);
        }

        private void RemoveStop_Click(object sender, EventArgs e) {
            if (this.Stops.SelectedIndex == -1) return;
            int index = this.Stops.SelectedIndex;
            foreach (Line line in this.railMap.lines) {
                while (line.stations.Contains(index)) {
                    int i = line.stations.IndexOf(index);
                    line.stations.RemoveAt(i);
                    line.sectionEnabled.RemoveAt(i);
                }
                for (int i = 0; i < line.stations.Count; i++)
                    if (line.stations[i] > index)
                        line.stations[i]--;
            }
            this.railMap.stations.RemoveAt(index);
            this.ReloadData(true, false, true);
        }

        private void RemoveLine_Click(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex == -1) return;
            this.railMap.lines.RemoveAt(this.Lines.SelectedIndex);
            this.ReloadData(false, true, true);
        }

        private void ModiftStop_Click(object sender, EventArgs e) {
            if (this.Stops.SelectedIndex == -1) return;
            StopSetting form = new(this.railMap.stations[this.Stops.SelectedIndex]);
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            this.ReloadData(true, false, false);
        }

        private void ModifyLine_Click(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex == -1) return;
            LineSetting form = new(this.railMap.lines[this.Lines.SelectedIndex]);
            if (sender is ToolStripMenuItem item)
                form.Text = item.Text;
            else
                form.Text = ((Control)sender).Text;
            form.ShowDialog();
            this.ReloadData(false, true, true);
        }

        private void ModifyStationFont_Click(object sender, EventArgs e) {
            FontDialog fd = new() {
                Font = this.railMap.font
            };
            if (fd.ShowDialog() == DialogResult.OK)
                this.railMap.font = fd.Font;
            this.ReloadData(false, false, false);
        }

        private void ModifyLegendFont_Click(object sender, EventArgs e) {
            FontDialog fd = new() {
                Font = this.railMap.legend.font
            };
            if (fd.ShowDialog() == DialogResult.OK)
                this.railMap.legend.font = fd.Font;
            this.ReloadData(false, false, false);
        }

        private void ZoomChange(object sender, EventArgs e) {
            this.Zoom.Text = ((ToolStripMenuItem)sender).Text;
            this.ReloadData(false, false, false);
        }

        private void SplitLine_Click(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex == -1) return;
            LineSetting form1 = new() {
                Text = "拆分线路"
            };
            form1.ShowDialog();
            if (form1.line == null) return;
            SplitLine form2 = new(this.railMap.lines[this.Lines.SelectedIndex], form1.line, this.railMap);
            form2.ShowDialog();
            this.ReloadData(false, true, true);
        }

        private void Check_Change(object sender, EventArgs e) {
            this.ReloadData(false, false, false);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e) {
            About form = new();
            form.ShowDialog();
            form.Dispose();
        }
        private void 上移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.railMap.MoveAll(0, -50);
            this.ReloadData(false, false, false);
        }

        private void 下移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.railMap.MoveAll(0, 50);
            this.ReloadData(false, false, false);
        }

        private void 左移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.railMap.MoveAll(-50, 0);
            this.ReloadData(false, false, false);
        }

        private void 右移50ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.railMap.MoveAll(50, 0);
            this.ReloadData(false, false, false);
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (this.controlPanel.Tag == null) return;
            this.controlPanel.Left = this.Width - (int)this.controlPanel.Tag;
            this.MapPanel.Width = this.controlPanel.Left - 10;
            this.MapPanel.Height = this.status.Top - this.menu.Height - 10;
            this.ReloadData(false, false, false);
        }

        private void ModifyStatus_Click(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex == -1) return;
            SectionSetting form = new(this.railMap, this.railMap.lines[this.Lines.SelectedIndex]);
            form.ShowDialog();
            this.ReloadData(false, false, false);
        }

        private void StarMeOnGithubToolStripMenuItem_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/IAFEnvoy/RailMapGenerator");
        }
        
        private void 支持ToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("感谢你的好意辣，但是作者现在还没有可以支持（如爱发电）的地方噢");
        }


        private void 图例设置ToolStripMenuItem_Click(object sender, EventArgs e) {
            LegendSetting form = new(this.railMap);
            form.ShowDialog();
            this.ReloadData(false, false, false);
        }

        private void 翻转车站顺序ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.Lines.SelectedIndex == -1) return;
            this.railMap.lines[this.Lines.SelectedIndex].stations.Reverse();
            this.ReloadData(false, false, true);
        }
    }
}
