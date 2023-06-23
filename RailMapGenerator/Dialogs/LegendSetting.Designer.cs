namespace RailMapGenerator {
    partial class LegendSetting {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.previewPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rel = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.xOffset = new System.Windows.Forms.TextBox();
            this.yOffset = new System.Windows.Forms.TextBox();
            this.zoom = new System.Windows.Forms.ComboBox();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Controls.Add(this.pictureBox1);
            this.previewPanel.Location = new System.Drawing.Point(12, 150);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(409, 311);
            this.previewPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 135);
            this.label1.TabIndex = 2;
            this.label1.Text = "    X轴位置:\r\n    Y轴位置:\r\n   图例方向:\r\n每行/列个数:\r\n       缩放:";
            // 
            // rel
            // 
            this.rel.FormattingEnabled = true;
            this.rel.Items.AddRange(new object[] {
            "横向",
            "纵向"});
            this.rel.Location = new System.Drawing.Point(181, 68);
            this.rel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rel.Name = "rel";
            this.rel.Size = new System.Drawing.Size(240, 23);
            this.rel.TabIndex = 3;
            this.rel.Text = "横向";
            this.rel.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(181, 94);
            this.count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(240, 25);
            this.count.TabIndex = 4;
            this.count.Text = "2";
            this.count.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // xOffset
            // 
            this.xOffset.Location = new System.Drawing.Point(181, 13);
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(240, 25);
            this.xOffset.TabIndex = 6;
            this.xOffset.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // yOffset
            // 
            this.yOffset.Location = new System.Drawing.Point(181, 40);
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(240, 25);
            this.yOffset.TabIndex = 7;
            this.yOffset.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // zoom
            // 
            this.zoom.FormattingEnabled = true;
            this.zoom.Items.AddRange(new object[] {
            "25%",
            "50%",
            "100%",
            "200%",
            "300%",
            "400%",
            "500%"});
            this.zoom.Location = new System.Drawing.Point(181, 122);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(240, 23);
            this.zoom.TabIndex = 8;
            this.zoom.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // LegendSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 473);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.count);
            this.Controls.Add(this.rel);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LegendSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图例设置";
            this.previewPanel.ResumeLayout(false);
            this.previewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox rel;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox xOffset;
        private System.Windows.Forms.TextBox yOffset;
        private System.Windows.Forms.ComboBox zoom;
    }
}