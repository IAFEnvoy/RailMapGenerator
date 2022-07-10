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
            this.autoText = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xOffset = new System.Windows.Forms.TextBox();
            this.yOffset = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(151, 225);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 47);
            this.add.TabIndex = 0;
            this.add.Text = "确定";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.OK_Click);
            // 
            // stopName
            // 
            this.stopName.Location = new System.Drawing.Point(151, 20);
            this.stopName.Name = "stopName";
            this.stopName.Size = new System.Drawing.Size(370, 25);
            this.stopName.TabIndex = 1;
            // 
            // positionX
            // 
            this.positionX.Location = new System.Drawing.Point(151, 47);
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(370, 25);
            this.positionX.TabIndex = 2;
            // 
            // positionY
            // 
            this.positionY.Location = new System.Drawing.Point(151, 74);
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(370, 25);
            this.positionY.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 16);
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
            this.enabled.Location = new System.Drawing.Point(151, 132);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(88, 31);
            this.enabled.TabIndex = 5;
            this.enabled.Text = "启用";
            this.enabled.UseVisualStyleBackColor = true;
            // 
            // renderRadium
            // 
            this.renderRadium.Location = new System.Drawing.Point(151, 101);
            this.renderRadium.Name = "renderRadium";
            this.renderRadium.Size = new System.Drawing.Size(370, 25);
            this.renderRadium.TabIndex = 6;
            this.renderRadium.Text = "10";
            // 
            // autoText
            // 
            this.autoText.AutoSize = true;
            this.autoText.Checked = true;
            this.autoText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoText.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoText.Location = new System.Drawing.Point(245, 132);
            this.autoText.Name = "autoText";
            this.autoText.Size = new System.Drawing.Size(250, 31);
            this.autoText.TabIndex = 7;
            this.autoText.Text = "自动计算文字位置";
            this.autoText.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "X轴偏移量:\r\nY轴偏移量:";
            // 
            // xOffset
            // 
            this.xOffset.Location = new System.Drawing.Point(151, 165);
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(370, 25);
            this.xOffset.TabIndex = 9;
            this.xOffset.TextChanged += new System.EventHandler(this.DisableAutoText);
            // 
            // yOffset
            // 
            this.yOffset.Location = new System.Drawing.Point(151, 194);
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(370, 25);
            this.yOffset.TabIndex = 10;
            this.yOffset.TextChanged += new System.EventHandler(this.DisableAutoText);
            // 
            // StopSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 281);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoText);
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
        private System.Windows.Forms.CheckBox autoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xOffset;
        private System.Windows.Forms.TextBox yOffset;
    }
}