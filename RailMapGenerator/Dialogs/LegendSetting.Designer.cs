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
            this.dir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rel = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.render = new System.Windows.Forms.Button();
            this.previewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Controls.Add(this.pictureBox1);
            this.previewPanel.Location = new System.Drawing.Point(12, 96);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(409, 342);
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
            // dir
            // 
            this.dir.FormattingEnabled = true;
            this.dir.Items.AddRange(new object[] {
            "左上",
            "左下",
            "右下",
            "右上"});
            this.dir.Location = new System.Drawing.Point(195, 12);
            this.dir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(159, 23);
            this.dir.TabIndex = 1;
            this.dir.Text = "左上";
            this.dir.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "   图例位置:\r\n   图例方向:\r\n每行/列个数:";
            // 
            // rel
            // 
            this.rel.FormattingEnabled = true;
            this.rel.Items.AddRange(new object[] {
            "横向",
            "纵向"});
            this.rel.Location = new System.Drawing.Point(195, 38);
            this.rel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rel.Name = "rel";
            this.rel.Size = new System.Drawing.Size(159, 23);
            this.rel.TabIndex = 3;
            this.rel.Text = "横向";
            this.rel.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(195, 65);
            this.count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(159, 25);
            this.count.TabIndex = 4;
            this.count.Text = "2";
            this.count.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // render
            // 
            this.render.Location = new System.Drawing.Point(359, 12);
            this.render.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.render.Name = "render";
            this.render.Size = new System.Drawing.Size(63, 79);
            this.render.TabIndex = 5;
            this.render.Text = "绘制";
            this.render.UseVisualStyleBackColor = true;
            this.render.Click += new System.EventHandler(this.Render_Click);
            // 
            // LegendSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 450);
            this.Controls.Add(this.render);
            this.Controls.Add(this.count);
            this.Controls.Add(this.rel);
            this.Controls.Add(this.dir);
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
        private System.Windows.Forms.ComboBox dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox rel;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Button render;
    }
}