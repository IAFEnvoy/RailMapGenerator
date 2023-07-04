namespace RailMapGenerator {
    partial class LineSetting {
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
            this.add = new System.Windows.Forms.Button();
            this.lineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(91, 114);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 53);
            this.add.TabIndex = 0;
            this.add.Text = "确定";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += this.OK_Click;
            // 
            // lineName
            // 
            this.lineName.Location = new System.Drawing.Point(91, 15);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(289, 23);
            this.lineName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "线路名称:\r\n\r\n线路颜色:\r\n\r\n绘制宽度:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(91, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 28);
            this.panel1.TabIndex = 5;
            this.panel1.Click += this.Panel1_Click;
            // 
            // lineWidth
            // 
            this.lineWidth.Location = new System.Drawing.Point(91, 79);
            this.lineWidth.Name = "lineWidth";
            this.lineWidth.Size = new System.Drawing.Size(289, 23);
            this.lineWidth.TabIndex = 6;
            this.lineWidth.Text = "6";
            // 
            // LineSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 179);
            this.Controls.Add(this.lineWidth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lineName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加线路";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox lineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lineWidth;
    }
}