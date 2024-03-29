﻿namespace RailMapGenerator {
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
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.修改区间开通状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翻转车站顺序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.整体移动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左移50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右移50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示站点名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示网格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示图例ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示未开通区间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示标尺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.字体设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站名字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图例字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图例设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快速算路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本地服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动本地服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本地服务器文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.清理内存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.绑定文件拓展名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.支持ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starMeOnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MapPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ModifyStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.map).BeginInit();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.MapPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.ImageLocation = "";
            this.map.Location = new System.Drawing.Point(67, 63);
            this.map.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(642, 426);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            // 
            // Stops
            // 
            this.Stops.FormattingEnabled = true;
            this.Stops.ItemHeight = 17;
            this.Stops.Location = new System.Drawing.Point(7, 37);
            this.Stops.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(160, 412);
            this.Stops.TabIndex = 111;
            this.Stops.DoubleClick += this.Stops_DoubleClick;
            // 
            // Lines
            // 
            this.Lines.FormattingEnabled = true;
            this.Lines.ItemHeight = 17;
            this.Lines.Location = new System.Drawing.Point(173, 37);
            this.Lines.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(160, 412);
            this.Lines.TabIndex = 111;
            this.Lines.SelectedIndexChanged += this.Lines_SelectedIndexChanged;
            this.Lines.DoubleClick += this.Lines_DoubleClick;
            // 
            // StopsOnLine
            // 
            this.StopsOnLine.FormattingEnabled = true;
            this.StopsOnLine.ItemHeight = 17;
            this.StopsOnLine.Location = new System.Drawing.Point(340, 37);
            this.StopsOnLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StopsOnLine.Name = "StopsOnLine";
            this.StopsOnLine.Size = new System.Drawing.Size(160, 412);
            this.StopsOnLine.TabIndex = 111;
            // 
            // AddStopToLine
            // 
            this.AddStopToLine.Location = new System.Drawing.Point(338, 524);
            this.AddStopToLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddStopToLine.Name = "AddStopToLine";
            this.AddStopToLine.Size = new System.Drawing.Size(161, 54);
            this.AddStopToLine.TabIndex = 4;
            this.AddStopToLine.Text = "将站点加入线路";
            this.AddStopToLine.UseVisualStyleBackColor = true;
            this.AddStopToLine.Click += this.AddStopToLine_Click;
            // 
            // AddLine
            // 
            this.AddLine.Location = new System.Drawing.Point(173, 465);
            this.AddLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddLine.Name = "AddLine";
            this.AddLine.Size = new System.Drawing.Size(161, 54);
            this.AddLine.TabIndex = 3;
            this.AddLine.Text = "添加线路";
            this.AddLine.UseVisualStyleBackColor = true;
            this.AddLine.Click += this.AddLine_Click;
            // 
            // AddStop
            // 
            this.AddStop.Location = new System.Drawing.Point(6, 465);
            this.AddStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddStop.Name = "AddStop";
            this.AddStop.Size = new System.Drawing.Size(161, 54);
            this.AddStop.TabIndex = 2;
            this.AddStop.Text = "添加站点";
            this.AddStop.UseVisualStyleBackColor = true;
            this.AddStop.Click += this.AddStop_Click;
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(338, 465);
            this.MoveUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(48, 54);
            this.MoveUp.TabIndex = 5;
            this.MoveUp.Text = "上移";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += this.MoveUp_Click;
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(394, 465);
            this.MoveDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(48, 54);
            this.MoveDown.TabIndex = 6;
            this.MoveDown.Text = "下移";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += this.MoveDown_Click;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(450, 465);
            this.Remove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(48, 54);
            this.Remove.TabIndex = 7;
            this.Remove.Text = "删除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += this.Remove_Click;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.文件ToolStripMenuItem, this.编辑ToolStripMenuItem, this.绘制ToolStripMenuItem, this.工具ToolStripMenuItem, this.帮助ToolStripMenuItem });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1293, 27);
            this.menu.TabIndex = 112;
            this.menu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.新建ToolStripMenuItem, this.打开ToolStripMenuItem, this.保存ToolStripMenuItem, this.另存为ToolStripMenuItem, this.toolStripSeparator1, this.导出ToolStripMenuItem, this.toolStripSeparator2, this.退出ToolStripMenuItem });
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += this.新建ToolStripMenuItem_Click;
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += this.打开ToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += this.保存ToolStripMenuItem_Click;
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += this.另存为ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S;
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.导出ToolStripMenuItem.Text = "导出为PNG";
            this.导出ToolStripMenuItem.Click += this.导出ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += this.退出ToolStripMenuItem_Click;
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.添加站点ToolStripMenuItem, this.修改站点信息ToolStripMenuItem, this.删除选中站点ToolStripMenuItem, this.toolStripSeparator3, this.添加线路ToolStripMenuItem, this.修改线路信息ToolStripMenuItem, this.删除选中线路ToolStripMenuItem, this.拆分线路ToolStripMenuItem, this.toolStripSeparator4, this.将站点加入线路ToolStripMenuItem, this.从线路中删除站点ToolStripMenuItem, this.修改区间开通状态ToolStripMenuItem, this.翻转车站顺序ToolStripMenuItem, this.toolStripSeparator6, this.整体移动ToolStripMenuItem });
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 添加站点ToolStripMenuItem
            // 
            this.添加站点ToolStripMenuItem.Name = "添加站点ToolStripMenuItem";
            this.添加站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.添加站点ToolStripMenuItem.Text = "添加站点";
            this.添加站点ToolStripMenuItem.Click += this.AddStop_Click;
            // 
            // 修改站点信息ToolStripMenuItem
            // 
            this.修改站点信息ToolStripMenuItem.Name = "修改站点信息ToolStripMenuItem";
            this.修改站点信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改站点信息ToolStripMenuItem.Text = "修改站点信息";
            this.修改站点信息ToolStripMenuItem.Click += this.ModiftStop_Click;
            // 
            // 删除选中站点ToolStripMenuItem
            // 
            this.删除选中站点ToolStripMenuItem.Name = "删除选中站点ToolStripMenuItem";
            this.删除选中站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中站点ToolStripMenuItem.Text = "删除选中站点";
            this.删除选中站点ToolStripMenuItem.Click += this.RemoveStop_Click;
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
            this.添加线路ToolStripMenuItem.Click += this.AddLine_Click;
            // 
            // 修改线路信息ToolStripMenuItem
            // 
            this.修改线路信息ToolStripMenuItem.Name = "修改线路信息ToolStripMenuItem";
            this.修改线路信息ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改线路信息ToolStripMenuItem.Text = "修改线路信息";
            this.修改线路信息ToolStripMenuItem.Click += this.ModifyLine_Click;
            // 
            // 删除选中线路ToolStripMenuItem
            // 
            this.删除选中线路ToolStripMenuItem.Name = "删除选中线路ToolStripMenuItem";
            this.删除选中线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.删除选中线路ToolStripMenuItem.Text = "删除选中线路";
            this.删除选中线路ToolStripMenuItem.Click += this.RemoveLine_Click;
            // 
            // 拆分线路ToolStripMenuItem
            // 
            this.拆分线路ToolStripMenuItem.Name = "拆分线路ToolStripMenuItem";
            this.拆分线路ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.拆分线路ToolStripMenuItem.Text = "拆分线路";
            this.拆分线路ToolStripMenuItem.Click += this.SplitLine_Click;
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
            this.将站点加入线路ToolStripMenuItem.Click += this.AddStopToLine_Click;
            // 
            // 从线路中删除站点ToolStripMenuItem
            // 
            this.从线路中删除站点ToolStripMenuItem.Name = "从线路中删除站点ToolStripMenuItem";
            this.从线路中删除站点ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.从线路中删除站点ToolStripMenuItem.Text = "从线路中删除站点";
            this.从线路中删除站点ToolStripMenuItem.Click += this.Remove_Click;
            // 
            // 修改区间开通状态ToolStripMenuItem
            // 
            this.修改区间开通状态ToolStripMenuItem.Name = "修改区间开通状态ToolStripMenuItem";
            this.修改区间开通状态ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.修改区间开通状态ToolStripMenuItem.Text = "修改区间开通状态";
            this.修改区间开通状态ToolStripMenuItem.Click += this.ModifyStatus_Click;
            // 
            // 翻转车站顺序ToolStripMenuItem
            // 
            this.翻转车站顺序ToolStripMenuItem.Name = "翻转车站顺序ToolStripMenuItem";
            this.翻转车站顺序ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.翻转车站顺序ToolStripMenuItem.Text = "翻转车站顺序";
            this.翻转车站顺序ToolStripMenuItem.Click += this.翻转车站顺序ToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
            // 
            // 整体移动ToolStripMenuItem
            // 
            this.整体移动ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.上移50ToolStripMenuItem, this.下移50ToolStripMenuItem, this.左移50ToolStripMenuItem, this.右移50ToolStripMenuItem });
            this.整体移动ToolStripMenuItem.Name = "整体移动ToolStripMenuItem";
            this.整体移动ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.整体移动ToolStripMenuItem.Text = "整体移动";
            // 
            // 上移50ToolStripMenuItem
            // 
            this.上移50ToolStripMenuItem.Name = "上移50ToolStripMenuItem";
            this.上移50ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.上移50ToolStripMenuItem.Text = "上移50";
            this.上移50ToolStripMenuItem.Click += this.上移50ToolStripMenuItem_Click;
            // 
            // 下移50ToolStripMenuItem
            // 
            this.下移50ToolStripMenuItem.Name = "下移50ToolStripMenuItem";
            this.下移50ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.下移50ToolStripMenuItem.Text = "下移50";
            this.下移50ToolStripMenuItem.Click += this.下移50ToolStripMenuItem_Click;
            // 
            // 左移50ToolStripMenuItem
            // 
            this.左移50ToolStripMenuItem.Name = "左移50ToolStripMenuItem";
            this.左移50ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.左移50ToolStripMenuItem.Text = "左移50";
            this.左移50ToolStripMenuItem.Click += this.左移50ToolStripMenuItem_Click;
            // 
            // 右移50ToolStripMenuItem
            // 
            this.右移50ToolStripMenuItem.Name = "右移50ToolStripMenuItem";
            this.右移50ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.右移50ToolStripMenuItem.Text = "右移50";
            this.右移50ToolStripMenuItem.Click += this.右移50ToolStripMenuItem_Click;
            // 
            // 绘制ToolStripMenuItem
            // 
            this.绘制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.显示站点名ToolStripMenuItem, this.显示网格ToolStripMenuItem, this.显示图例ToolStripMenuItem, this.显示未开通区间ToolStripMenuItem, this.显示标尺ToolStripMenuItem, this.toolStripSeparator5, this.字体设置ToolStripMenuItem, this.图例设置ToolStripMenuItem, this.项目设置ToolStripMenuItem });
            this.绘制ToolStripMenuItem.Name = "绘制ToolStripMenuItem";
            this.绘制ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.绘制ToolStripMenuItem.Text = "绘制";
            // 
            // 显示站点名ToolStripMenuItem
            // 
            this.显示站点名ToolStripMenuItem.Checked = true;
            this.显示站点名ToolStripMenuItem.CheckOnClick = true;
            this.显示站点名ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示站点名ToolStripMenuItem.Name = "显示站点名ToolStripMenuItem";
            this.显示站点名ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示站点名ToolStripMenuItem.Text = "显示站点名";
            this.显示站点名ToolStripMenuItem.CheckedChanged += this.Check_Change;
            // 
            // 显示网格ToolStripMenuItem
            // 
            this.显示网格ToolStripMenuItem.Checked = true;
            this.显示网格ToolStripMenuItem.CheckOnClick = true;
            this.显示网格ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示网格ToolStripMenuItem.Name = "显示网格ToolStripMenuItem";
            this.显示网格ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示网格ToolStripMenuItem.Text = "显示网格";
            this.显示网格ToolStripMenuItem.CheckedChanged += this.Check_Change;
            // 
            // 显示图例ToolStripMenuItem
            // 
            this.显示图例ToolStripMenuItem.Checked = true;
            this.显示图例ToolStripMenuItem.CheckOnClick = true;
            this.显示图例ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示图例ToolStripMenuItem.Name = "显示图例ToolStripMenuItem";
            this.显示图例ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示图例ToolStripMenuItem.Text = "显示图例";
            this.显示图例ToolStripMenuItem.CheckedChanged += this.Check_Change;
            // 
            // 显示未开通区间ToolStripMenuItem
            // 
            this.显示未开通区间ToolStripMenuItem.Checked = true;
            this.显示未开通区间ToolStripMenuItem.CheckOnClick = true;
            this.显示未开通区间ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示未开通区间ToolStripMenuItem.Name = "显示未开通区间ToolStripMenuItem";
            this.显示未开通区间ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示未开通区间ToolStripMenuItem.Text = "显示未开通区间";
            this.显示未开通区间ToolStripMenuItem.CheckedChanged += this.Check_Change;
            // 
            // 显示标尺ToolStripMenuItem
            // 
            this.显示标尺ToolStripMenuItem.Checked = true;
            this.显示标尺ToolStripMenuItem.CheckOnClick = true;
            this.显示标尺ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示标尺ToolStripMenuItem.Name = "显示标尺ToolStripMenuItem";
            this.显示标尺ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.显示标尺ToolStripMenuItem.Text = "显示标尺";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // 字体设置ToolStripMenuItem
            // 
            this.字体设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.站名字体ToolStripMenuItem, this.图例字体ToolStripMenuItem });
            this.字体设置ToolStripMenuItem.Name = "字体设置ToolStripMenuItem";
            this.字体设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.字体设置ToolStripMenuItem.Text = "字体设置";
            // 
            // 站名字体ToolStripMenuItem
            // 
            this.站名字体ToolStripMenuItem.Name = "站名字体ToolStripMenuItem";
            this.站名字体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.站名字体ToolStripMenuItem.Text = "站名字体";
            this.站名字体ToolStripMenuItem.Click += this.ModifyStationFont_Click;
            // 
            // 图例字体ToolStripMenuItem
            // 
            this.图例字体ToolStripMenuItem.Name = "图例字体ToolStripMenuItem";
            this.图例字体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图例字体ToolStripMenuItem.Text = "图例字体";
            this.图例字体ToolStripMenuItem.Click += this.ModifyLegendFont_Click;
            // 
            // 图例设置ToolStripMenuItem
            // 
            this.图例设置ToolStripMenuItem.Name = "图例设置ToolStripMenuItem";
            this.图例设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.图例设置ToolStripMenuItem.Text = "图例设置";
            this.图例设置ToolStripMenuItem.Click += this.图例设置ToolStripMenuItem_Click;
            // 
            // 项目设置ToolStripMenuItem
            // 
            this.项目设置ToolStripMenuItem.Enabled = false;
            this.项目设置ToolStripMenuItem.Name = "项目设置ToolStripMenuItem";
            this.项目设置ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.项目设置ToolStripMenuItem.Text = "项目设置";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.快速算路ToolStripMenuItem, this.本地服务器ToolStripMenuItem, this.toolStripSeparator7, this.清理内存ToolStripMenuItem, this.toolStripSeparator8, this.绑定文件拓展名ToolStripMenuItem });
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 快速算路ToolStripMenuItem
            // 
            this.快速算路ToolStripMenuItem.Name = "快速算路ToolStripMenuItem";
            this.快速算路ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.快速算路ToolStripMenuItem.Text = "快速算路";
            this.快速算路ToolStripMenuItem.Click += this.快速算路ToolStripMenuItem_Click;
            // 
            // 本地服务器ToolStripMenuItem
            // 
            this.本地服务器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.启动本地服务器ToolStripMenuItem, this.本地服务器文档ToolStripMenuItem });
            this.本地服务器ToolStripMenuItem.Name = "本地服务器ToolStripMenuItem";
            this.本地服务器ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.本地服务器ToolStripMenuItem.Text = "本地服务器";
            // 
            // 启动本地服务器ToolStripMenuItem
            // 
            this.启动本地服务器ToolStripMenuItem.Name = "启动本地服务器ToolStripMenuItem";
            this.启动本地服务器ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.启动本地服务器ToolStripMenuItem.Text = "启动本地服务器";
            this.启动本地服务器ToolStripMenuItem.Click += this.启动本地服务器ToolStripMenuItem_Click;
            // 
            // 本地服务器文档ToolStripMenuItem
            // 
            this.本地服务器文档ToolStripMenuItem.Name = "本地服务器文档ToolStripMenuItem";
            this.本地服务器文档ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.本地服务器文档ToolStripMenuItem.Text = "本地服务器文档";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // 清理内存ToolStripMenuItem
            // 
            this.清理内存ToolStripMenuItem.Name = "清理内存ToolStripMenuItem";
            this.清理内存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清理内存ToolStripMenuItem.Text = "清理内存";
            this.清理内存ToolStripMenuItem.Click += this.清理内存ToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // 绑定文件拓展名ToolStripMenuItem
            // 
            this.绑定文件拓展名ToolStripMenuItem.Enabled = false;
            this.绑定文件拓展名ToolStripMenuItem.Name = "绑定文件拓展名ToolStripMenuItem";
            this.绑定文件拓展名ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.绑定文件拓展名ToolStripMenuItem.Text = "绑定文件拓展名";
            this.绑定文件拓展名ToolStripMenuItem.Click += this.绑定文件拓展名ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.支持ToolStripMenuItem, this.starMeOnGithubToolStripMenuItem, this.关于ToolStripMenuItem });
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 支持ToolStripMenuItem
            // 
            this.支持ToolStripMenuItem.Name = "支持ToolStripMenuItem";
            this.支持ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.支持ToolStripMenuItem.Text = "支持";
            this.支持ToolStripMenuItem.Click += this.支持ToolStripMenuItem_Click;
            // 
            // starMeOnGithubToolStripMenuItem
            // 
            this.starMeOnGithubToolStripMenuItem.Name = "starMeOnGithubToolStripMenuItem";
            this.starMeOnGithubToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.starMeOnGithubToolStripMenuItem.Text = "Star me on Github";
            this.starMeOnGithubToolStripMenuItem.Click += this.StarMeOnGithubToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Enabled = false;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += this.关于ToolStripMenuItem_Click;
            // 
            // RemoveStop
            // 
            this.RemoveStop.Location = new System.Drawing.Point(6, 581);
            this.RemoveStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RemoveStop.Name = "RemoveStop";
            this.RemoveStop.Size = new System.Drawing.Size(161, 54);
            this.RemoveStop.TabIndex = 113;
            this.RemoveStop.Text = "删除选中站点";
            this.RemoveStop.UseVisualStyleBackColor = true;
            this.RemoveStop.Click += this.RemoveStop_Click;
            // 
            // RemoveLine
            // 
            this.RemoveLine.Location = new System.Drawing.Point(173, 581);
            this.RemoveLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RemoveLine.Name = "RemoveLine";
            this.RemoveLine.Size = new System.Drawing.Size(161, 54);
            this.RemoveLine.TabIndex = 114;
            this.RemoveLine.Text = "删除选中线路";
            this.RemoveLine.UseVisualStyleBackColor = true;
            this.RemoveLine.Click += this.RemoveLine_Click;
            // 
            // ModiftStop
            // 
            this.ModiftStop.Location = new System.Drawing.Point(6, 524);
            this.ModiftStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ModiftStop.Name = "ModiftStop";
            this.ModiftStop.Size = new System.Drawing.Size(161, 54);
            this.ModiftStop.TabIndex = 115;
            this.ModiftStop.Text = "修改站点信息";
            this.ModiftStop.UseVisualStyleBackColor = true;
            this.ModiftStop.Click += this.ModiftStop_Click;
            // 
            // ModifyLine
            // 
            this.ModifyLine.Location = new System.Drawing.Point(173, 524);
            this.ModifyLine.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ModifyLine.Name = "ModifyLine";
            this.ModifyLine.Size = new System.Drawing.Size(161, 54);
            this.ModifyLine.TabIndex = 116;
            this.ModifyLine.Text = "修改线路信息";
            this.ModifyLine.UseVisualStyleBackColor = true;
            this.ModifyLine.Click += this.ModifyLine_Click;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.Zoom, this.AuthorName, this.FileStatus });
            this.status.Location = new System.Drawing.Point(0, 688);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.status.Size = new System.Drawing.Size(1293, 23);
            this.status.TabIndex = 120;
            this.status.Text = "statusStrip1";
            // 
            // Zoom
            // 
            this.Zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem8, this.toolStripMenuItem7, this.toolStripMenuItem6, this.toolStripMenuItem5, this.toolStripMenuItem4, this.toolStripMenuItem3, this.toolStripMenuItem2 });
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
            this.toolStripMenuItem8.Click += this.ZoomChange;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem7.Text = "50%";
            this.toolStripMenuItem7.Click += this.ZoomChange;
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem6.Text = "100%";
            this.toolStripMenuItem6.Click += this.ZoomChange;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem5.Text = "200%";
            this.toolStripMenuItem5.Click += this.ZoomChange;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem4.Text = "300%";
            this.toolStripMenuItem4.Click += this.ZoomChange;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem3.Text = "400%";
            this.toolStripMenuItem3.Click += this.ZoomChange;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem2.Text = "500%";
            this.toolStripMenuItem2.Click += this.ZoomChange;
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
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 121;
            this.label1.Text = "车站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 122;
            this.label2.Text = "线路";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(341, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 123;
            this.label3.Text = "线路上的车站";
            // 
            // MapPanel
            // 
            this.MapPanel.AutoScroll = true;
            this.MapPanel.Controls.Add(this.map);
            this.MapPanel.Location = new System.Drawing.Point(12, 37);
            this.MapPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(756, 646);
            this.MapPanel.TabIndex = 127;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.ModifyStatus);
            this.controlPanel.Controls.Add(this.Stops);
            this.controlPanel.Controls.Add(this.Lines);
            this.controlPanel.Controls.Add(this.StopsOnLine);
            this.controlPanel.Controls.Add(this.AddStopToLine);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.AddLine);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.AddStop);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.MoveUp);
            this.controlPanel.Controls.Add(this.MoveDown);
            this.controlPanel.Controls.Add(this.ModifyLine);
            this.controlPanel.Controls.Add(this.Remove);
            this.controlPanel.Controls.Add(this.ModiftStop);
            this.controlPanel.Controls.Add(this.RemoveStop);
            this.controlPanel.Controls.Add(this.RemoveLine);
            this.controlPanel.Location = new System.Drawing.Point(774, 37);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(509, 646);
            this.controlPanel.TabIndex = 128;
            // 
            // ModifyStatus
            // 
            this.ModifyStatus.Location = new System.Drawing.Point(338, 581);
            this.ModifyStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ModifyStatus.Name = "ModifyStatus";
            this.ModifyStatus.Size = new System.Drawing.Size(161, 54);
            this.ModifyStatus.TabIndex = 124;
            this.ModifyStatus.Text = "修改区间开通状态";
            this.ModifyStatus.UseVisualStyleBackColor = true;
            this.ModifyStatus.Click += this.ModifyStatus_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 711);
            this.Controls.Add(this.MapPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(526, 750);
            this.Name = "MainForm";
            this.Text = "线路图生成器";
            this.FormClosing += this.MainForm_FormClosing;
            this.Resize += this.MainForm_Resize;
            ((System.ComponentModel.ISupportInitialize)this.map).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripDropDownButton Zoom;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘制ToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem 字体设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 支持ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 整体移动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左移50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右移50ToolStripMenuItem;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.ToolStripMenuItem 修改区间开通状态ToolStripMenuItem;
        private System.Windows.Forms.Button ModifyStatus;
        private System.Windows.Forms.ToolStripMenuItem starMeOnGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 显示图例ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图例设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 站名字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图例字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翻转车站顺序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快速算路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示未开通区间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本地服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动本地服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本地服务器文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 清理内存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示标尺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 绑定文件拓展名ToolStripMenuItem;
    }
}