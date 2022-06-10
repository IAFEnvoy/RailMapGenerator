namespace RailMapGenerator.Dialogs {
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
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(166, 74);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 47);
            this.add.TabIndex = 0;
            this.add.Text = "确定";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OK_Click);
            // 
            // lineName
            // 
            this.lineName.Location = new System.Drawing.Point(166, 12);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(330, 25);
            this.lineName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "线路名称:\r\n线路颜色:\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(166, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 25);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // LineSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 132);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineName);
            this.Controls.Add(this.add);
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
    }
}