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
            this.enabled = new System.Windows.Forms.CheckBox();
            this.renderRadium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(139, 163);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 47);
            this.add.TabIndex = 0;
            this.add.Text = "确定";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OK_Click);
            // 
            // stopName
            // 
            this.stopName.Location = new System.Drawing.Point(139, 19);
            this.stopName.Name = "stopName";
            this.stopName.Size = new System.Drawing.Size(330, 25);
            this.stopName.TabIndex = 1;
            // 
            // positionX
            // 
            this.positionX.Location = new System.Drawing.Point(139, 46);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(330, 25);
            this.positionX.TabIndex = 2;
            // 
            // positionY
            // 
            this.positionY.Location = new System.Drawing.Point(139, 73);
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
            this.label1.Size = new System.Drawing.Size(136, 108);
            this.label1.TabIndex = 4;
            this.label1.Text = "站点名称:\r\n   X坐标:\r\n   Y坐标:\r\n绘制半径:";
            // 
            // enabled
            // 
            this.enabled.AutoSize = true;
            this.enabled.Checked = true;
            this.enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabled.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enabled.Location = new System.Drawing.Point(139, 131);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(88, 31);
            this.enabled.TabIndex = 5;
            this.enabled.Text = "启用";
            this.enabled.UseVisualStyleBackColor = true;
            // 
            // renderRadium
            // 
            this.renderRadium.Location = new System.Drawing.Point(139, 100);
            this.renderRadium.Name = "renderRadium";
            this.renderRadium.Size = new System.Drawing.Size(330, 25);
            this.renderRadium.TabIndex = 6;
            this.renderRadium.Text = "10";
            // 
            // StopSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 216);
            this.Controls.Add(this.renderRadium);
            this.Controls.Add(this.enabled);
            this.Controls.Add(this.positionY);
            this.Controls.Add(this.positionX);
            this.Controls.Add(this.stopName);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.CheckBox enabled;
        private System.Windows.Forms.TextBox renderRadium;
    }
}