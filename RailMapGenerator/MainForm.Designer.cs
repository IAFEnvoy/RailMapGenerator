namespace RailMapGenerator {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.map = new System.Windows.Forms.PictureBox();
            this.Stops = new System.Windows.Forms.ListBox();
            this.Lines = new System.Windows.Forms.ListBox();
            this.StopsOnLine = new System.Windows.Forms.ListBox();
            this.AddStopToLine = new System.Windows.Forms.Button();
            this.AddLine = new System.Windows.Forms.Button();
            this.AddStop = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加站点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改站点信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中站点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.添加线路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改线路信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中线路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拆分线路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.将站点加入线路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从线路中删除站点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示站点名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示网格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站名字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.快捷键设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStop = new System.Windows.Forms.Button();
            this.RemoveLine = new System.Windows.Forms.Button();
            this.ModiftStop = new System.Windows.Forms.Button();
            this.ModifyLine = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.Zoom = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.FileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MapHorizonSB = new System.Windows.Forms.HScrollBar();
            this.MapVerticalSB = new System.Windows.Forms.VScrollBar();
            this.MapPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.MapPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.ImageLocation = "";
            this.map.Location = new System.Drawing.Point(71, 42);
            this.map.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(642, 426);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // Stops
            // 
            this.Stops.FormattingEnabled = true;
            this.Stops.ItemHeight = 12;
            this.Stops.Location = new System.Drawing.Point(676, 52);
            this.Stops.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(138, 292);
            this.Stops.TabIndex = 111;
            // 
            // Lines
            // 
            this.Lines.FormattingEnabled = true;
            this.Lines.ItemHeight = 12;
            this.Lines.Location = new System.Drawing.Point(818, 52);
            this.Lines.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(138, 292);
            this.Lines.TabIndex = 111;
            this.Lines.SelectedIndexChanged += new System.EventHandler(this.Lines_SelectedIndexChanged);
            // 
            // StopsOnLine
            // 
            this.StopsOnLine.FormattingEnabled = true;
            this.StopsOnLine.ItemHeight = 12;
            this.StopsOnLine.Location = new System.Drawing.Point(961, 52);
            this.StopsOnLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StopsOnLine.Name = "StopsOnLine";
            this.StopsOnLine.Size = new System.Drawing.Size(138, 292);
            this.StopsOnLine.TabIndex = 111;
            // 
            // AddStopToLine
            // 
            this.AddStopToLine.Location = new System.Drawing.Point(959, 395);
            this.AddStopToLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddStopToLine.Name = "AddStopToLine";
            this.AddStopToLine.Size = new System.Drawing.Size(138, 38);
            this.AddStopToLine.TabIndex = 4;
            this.AddStopToLine.Text = "将站点加入线路";
            this.AddStopToLine.UseVisualStyleBackColor = true;
            this.AddStopToLine.Click += new System.EventHandler(this.AddStopToLine_Click);
            // 
            // AddLine
            // 
            this.AddLine.Location = new System.Drawing.Point(818, 354);
            this.AddLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(138, 38);
            this.AddLine.TabIndex = 3;
            this.AddLine.Text = "添加线路";
            this.AddLine.UseVisualStyleBackColor = true;
            this.AddLine.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // AddStop
            // 
            this.AddStop.Location = new System.Drawing.Point(675, 354);
            this.AddStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddStop.Name = "AddStop";
            this.AddStop.Size = new System.Drawing.Size(138, 38);
            this.AddStop.TabIndex = 2;
            this.AddStop.Text = "添加站点";
            this.AddStop.UseVisualStyleBackColor = true;
            this.AddStop.Click += new System.EventHandler(this.AddStop_Click);
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(959, 354);
            this.MoveUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(41, 38);
            this.MoveUp.TabIndex = 5;
            this.MoveUp.Text = "上移";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(1007, 354);
            this.MoveDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(41, 38);
            this.MoveDown.TabIndex = 6;
            this.MoveDown.Text = "下移";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(1056, 354);
            this.Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(41, 38);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "删除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(1104, 25);
            this.menu.TabIndex = 112;
            this.menu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripSeparator1,
            this.导出ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.导出ToolStripMenuItem.Text = "导出为PNG";
            this.导出ToolStripMenuItem.Click += new System.EventHandler(this.导出ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加站点ToolStripMenuItem,
            this.修改站点信息ToolStripMenuItem,
            this.删除选中站点ToolStripMenuItem,
            this.toolStripSeparator3,
            this.添加线路ToolStripMenuItem,
            this.修改线路信息ToolStripMenuItem,
            this.删除选中线路ToolStripMenuItem,
            this.拆分线路ToolStripMenuItem,
            this.toolStripSeparator4,
            this.将站点加入线路ToolStripMenuItem,
            this.从线路中删除站点ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // 添加站点ToolStripMenuItem
            // 
            this.添加站点ToolStripMenuItem.Name = "添加站点ToolStripMenuItem";
            this.添加站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加站点ToolStripMenuItem.Text = "添加站点";
            this.添加站点ToolStripMenuItem.Click += new System.EventHandler(this.AddStop_Click);
            // 
            // 修改站点信息ToolStripMenuItem
            // 
            this.修改站点信息ToolStripMenuItem.Name = "修改站点信息ToolStripMenuItem";
            this.修改站点信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改站点信息ToolStripMenuItem.Text = "修改站点信息";
            this.修改站点信息ToolStripMenuItem.Click += new System.EventHandler(this.ModiftStop_Click);
            // 
            // 删除选中站点ToolStripMenuItem
            // 
            this.删除选中站点ToolStripMenuItem.Name = "删除选中站点ToolStripMenuItem";
            this.删除选中站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中站点ToolStripMenuItem.Text = "删除选中站点";
            this.删除选中站点ToolStripMenuItem.Click += new System.EventHandler(this.RemoveStop_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // 添加线路ToolStripMenuItem
            // 
            this.添加线路ToolStripMenuItem.Name = "添加线路ToolStripMenuItem";
            this.添加线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加线路ToolStripMenuItem.Text = "添加线路";
            this.添加线路ToolStripMenuItem.Click += new System.EventHandler(this.AddLine_Click);
            // 
            // 修改线路信息ToolStripMenuItem
            // 
            this.修改线路信息ToolStripMenuItem.Name = "修改线路信息ToolStripMenuItem";
            this.修改线路信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改线路信息ToolStripMenuItem.Text = "修改线路信息";
            this.修改线路信息ToolStripMenuItem.Click += new System.EventHandler(this.ModifyLine_Click);
            // 
            // 删除选中线路ToolStripMenuItem
            // 
            this.删除选中线路ToolStripMenuItem.Name = "删除选中线路ToolStripMenuItem";
            this.删除选中线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中线路ToolStripMenuItem.Text = "删除选中线路";
            this.删除选中线路ToolStripMenuItem.Click += new System.EventHandler(this.RemoveLine_Click);
            // 
            // 拆分线路ToolStripMenuItem
            // 
            this.拆分线路ToolStripMenuItem.Name = "拆分线路ToolStripMenuItem";
            this.拆分线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.拆分线路ToolStripMenuItem.Text = "拆分线路";
            this.拆分线路ToolStripMenuItem.Click += new System.EventHandler(this.SplitLine_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // 将站点加入线路ToolStripMenuItem
            // 
            this.将站点加入线路ToolStripMenuItem.Name = "将站点加入线路ToolStripMenuItem";
            this.将站点加入线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.将站点加入线路ToolStripMenuItem.Text = "将站点加入线路";
            this.将站点加入线路ToolStripMenuItem.Click += new System.EventHandler(this.AddStopToLine_Click);
            // 
            // 从线路中删除站点ToolStripMenuItem
            // 
            this.从线路中删除站点ToolStripMenuItem.Name = "从线路中删除站点ToolStripMenuItem";
            this.从线路中删除站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.从线路中删除站点ToolStripMenuItem.Text = "从线路中删除站点";
            this.从线路中删除站点ToolStripMenuItem.Click += new System.EventHandler(this.Remove_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示站点名ToolStripMenuItem,
            this.显示网格ToolStripMenuItem,
            this.站名字体ToolStripMenuItem,
            this.toolStripSeparator5,
            this.快捷键设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 显示站点名ToolStripMenuItem
            // 
            this.显示站点名ToolStripMenuItem.Checked = true;
            this.显示站点名ToolStripMenuItem.CheckOnClick = true;
            this.显示站点名ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示站点名ToolStripMenuItem.Name = "显示站点名ToolStripMenuItem";
            this.显示站点名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示站点名ToolStripMenuItem.Text = "显示站点名";
            this.显示站点名ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Check_Change);
            // 
            // 显示网格ToolStripMenuItem
            // 
            this.显示网格ToolStripMenuItem.Checked = true;
            this.显示网格ToolStripMenuItem.CheckOnClick = true;
            this.显示网格ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示网格ToolStripMenuItem.Name = "显示网格ToolStripMenuItem";
            this.显示网格ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示网格ToolStripMenuItem.Text = "显示网格";
            this.显示网格ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.Check_Change);
            // 
            // 站名字体ToolStripMenuItem
            // 
            this.站名字体ToolStripMenuItem.Name = "站名字体ToolStripMenuItem";
            this.站名字体ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.站名字体ToolStripMenuItem.Text = "站名字体";
            this.站名字体ToolStripMenuItem.Click += new System.EventHandler(this.ModiftFont_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // 快捷键设置ToolStripMenuItem
            // 
            this.快捷键设置ToolStripMenuItem.Name = "快捷键设置ToolStripMenuItem";
            this.快捷键设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.快捷键设置ToolStripMenuItem.Text = "快捷键设置";
            this.快捷键设置ToolStripMenuItem.Click += new System.EventHandler(this.快捷键设置ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // RemoveStop
            // 
            this.RemoveStop.Location = new System.Drawing.Point(675, 436);
            this.RemoveStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveStop.Name = "RemoveStop";
            this.RemoveStop.Size = new System.Drawing.Size(138, 38);
            this.RemoveStop.TabIndex = 113;
            this.RemoveStop.Text = "删除选中站点";
            this.RemoveStop.UseVisualStyleBackColor = true;
            this.RemoveStop.Click += new System.EventHandler(this.RemoveStop_Click);
            // 
            // RemoveLine
            // 
            this.RemoveLine.Location = new System.Drawing.Point(818, 436);
            this.RemoveLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveLine.Name = "RemoveLine";
            this.RemoveLine.Size = new System.Drawing.Size(138, 38);
            this.RemoveLine.TabIndex = 114;
            this.RemoveLine.Text = "删除选中线路";
            this.RemoveLine.UseVisualStyleBackColor = true;
            this.RemoveLine.Click += new System.EventHandler(this.RemoveLine_Click);
            // 
            // ModiftStop
            // 
            this.ModiftStop.Location = new System.Drawing.Point(675, 395);
            this.ModiftStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModiftStop.Name = "ModiftStop";
            this.ModiftStop.Size = new System.Drawing.Size(138, 38);
            this.ModiftStop.TabIndex = 115;
            this.ModiftStop.Text = "修改站点信息";
            this.ModiftStop.UseVisualStyleBackColor = true;
            this.ModiftStop.Click += new System.EventHandler(this.ModiftStop_Click);
            // 
            // ModifyLine
            // 
            this.ModifyLine.Location = new System.Drawing.Point(818, 395);
            this.ModifyLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyLine.Name = "ModifyLine";
            this.ModifyLine.Size = new System.Drawing.Size(138, 38);
            this.ModifyLine.TabIndex = 116;
            this.ModifyLine.Text = "修改线路信息";
            this.ModifyLine.UseVisualStyleBackColor = true;
            this.ModifyLine.Click += new System.EventHandler(this.ModifyLine_Click);
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zoom,
            this.AuthorName,
            this.FileStatus});
            this.status.Location = new System.Drawing.Point(0, 478);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1104, 23);
            this.status.SizingGrip = false;
            this.status.TabIndex = 120;
            this.status.Text = "statusStrip1";
            // 
            // Zoom
            // 
            this.Zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.Zoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(53, 21);
            this.Zoom.Text = "100%";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem8.Text = "25%";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem7.Text = "50%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem6.Text = "100%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem5.Text = "200%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem4.Text = "300%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem3.Text = "400%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ZoomChange);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem2.Text = "500%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ZoomChange);
            // 
            // AuthorName
            // 
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(113, 18);
            this.AuthorName.Text = "Code By IAFEnvoy";
            // 
            // FileStatus
            // 
            this.FileStatus.Name = "FileStatus";
            this.FileStatus.Size = new System.Drawing.Size(0, 18);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(677, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "车站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(819, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 122;
            this.label2.Text = "线路";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(962, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "线路上的车站";
            // 
            // MapHorizonSB
            // 
            this.MapHorizonSB.LargeChange = 1;
            this.MapHorizonSB.Location = new System.Drawing.Point(9, 461);
            this.MapHorizonSB.Maximum = 0;
            this.MapHorizonSB.Name = "MapHorizonSB";
            this.MapHorizonSB.Size = new System.Drawing.Size(644, 18);
            this.MapHorizonSB.TabIndex = 125;
            this.MapHorizonSB.ValueChanged += new System.EventHandler(this.MapHorizonSB_ValueChanged);
            // 
            // MapVerticalSB
            // 
            this.MapVerticalSB.LargeChange = 1;
            this.MapVerticalSB.Location = new System.Drawing.Point(656, 30);
            this.MapVerticalSB.Maximum = 0;
            this.MapVerticalSB.Name = "MapVerticalSB";
            this.MapVerticalSB.Size = new System.Drawing.Size(18, 428);
            this.MapVerticalSB.TabIndex = 126;
            this.MapVerticalSB.ValueChanged += new System.EventHandler(this.MapVerticalSB_ValueChanged);
            // 
            // MapPanel
            // 
            this.MapPanel.Controls.Add(this.map);
            this.MapPanel.Location = new System.Drawing.Point(12, 28);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(641, 430);
            this.MapPanel.TabIndex = 127;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 501);
            this.Controls.Add(this.MapPanel);
            this.Controls.Add(this.MapVerticalSB);
            this.Controls.Add(this.MapHorizonSB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.ModifyLine);
            this.Controls.Add(this.ModiftStop);
            this.Controls.Add(this.RemoveLine);
            this.Controls.Add(this.RemoveStop);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.AddStop);
            this.Controls.Add(this.AddLine);
            this.Controls.Add(this.AddStopToLine);
            this.Controls.Add(this.StopsOnLine);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.Stops);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "线路图生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.ListBox Stops;
        private System.Windows.Forms.ListBox Lines;
        private System.Windows.Forms.ListBox StopsOnLine;
        private System.Windows.Forms.Button AddStopToLine;
        private System.Windows.Forms.Button AddLine;
        private System.Windows.Forms.Button AddStop;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button RemoveStop;
        private System.Windows.Forms.Button RemoveLine;
        private System.Windows.Forms.Button ModiftStop;
        private System.Windows.Forms.Button ModifyLine;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel AuthorName;
        private System.Windows.Forms.ToolStripStatusLabel FileStatus;
        private System.Windows.Forms.HScrollBar MapHorizonSB;
        private System.Windows.Forms.VScrollBar MapVerticalSB;
        private System.Windows.Forms.ToolStripDropDownButton Zoom;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加站点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改站点信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中站点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 添加线路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改线路信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中线路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拆分线路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 将站点加入线路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从线路中删除站点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示站点名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示网格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 站名字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 快捷键设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}