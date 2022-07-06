namespace RailMapGenerator {
    partial class StopSetting {
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
            this.stopName = new System.Windows.Forms.TextBox();
            this.positionX = new System.Windows.Forms.TextBox();
            this.positionY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(166, 142);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 47);
            this.add.TabIndex = 0;
            this.add.Text = "确定";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OK_Click);
            // 
            // stopName
            // 
            this.stopName.Location = new System.Drawing.Point(166, 12);
            this.stopName.Name = "stopName";
            this.stopName.Size = new System.Drawing.Size(330, 25);
            this.stopName.TabIndex = 1;
            // 
            // positionX
            // 
            this.positionX.Location = new System.Drawing.Point(167, 43);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(330, 25);
            this.positionX.TabIndex = 2;
            // 
            // positionY
            // 
            this.positionY.Location = new System.Drawing.Point(167, 74);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(330, 25);
            this.positionY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "站点名称:\r\n   X坐标:\r\n   Y坐标:\r\n";
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Checked = true;
            this.enable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enable.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enable.Location = new System.Drawing.Point(169, 105);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(88, 31);
            this.enable.TabIndex = 5;
            this.enable.Text = "启用";
            this.enable.UseVisualStyleBackColor = true;
            // 
            // StopSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 196);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.positionX);
            this.Controls.Add(this.stopName);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StopSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加站点";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox stopName;
        private System.Windows.Forms.TextBox positionX;
        private System.Windows.Forms.TextBox positionY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enable;
    }
}