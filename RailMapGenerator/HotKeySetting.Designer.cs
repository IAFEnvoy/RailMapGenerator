namespace RailMapGenerator {
    partial class HotKeySetting {
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
            this.HotKeyTargets = new System.Windows.Forms.ListBox();
            this.HotKeyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HotKeyTargets
            // 
            this.HotKeyTargets.FormattingEnabled = true;
            this.HotKeyTargets.ItemHeight = 15;
            this.HotKeyTargets.Location = new System.Drawing.Point(12, 12);
            this.HotKeyTargets.Name = "HotKeyTargets";
            this.HotKeyTargets.Size = new System.Drawing.Size(416, 424);
            this.HotKeyTargets.TabIndex = 0;
            this.HotKeyTargets.SelectedIndexChanged += new System.EventHandler(this.HotKeyTargets_SelectedIndexChanged);
            // 
            // HotKeyInput
            // 
            this.HotKeyInput.Location = new System.Drawing.Point(434, 98);
            this.HotKeyInput.Name = "HotKeyInput";
            this.HotKeyInput.Size = new System.Drawing.Size(320, 25);
            this.HotKeyInput.TabIndex = 1;
            this.HotKeyInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyInput_KeyDown);
            this.HotKeyInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HotKeyInput_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(434, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 83);
            this.label1.TabIndex = 2;
            this.label1.Text = "快捷键\r\n（仅支持Ctrl,Shift,Alt和所有字母数字）";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(434, 129);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(83, 55);
            this.OK.TabIndex = 3;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(523, 129);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(83, 55);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "清除";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // HotKeySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HotKeyInput);
            this.Controls.Add(this.HotKeyTargets);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotKeySetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "快捷键设置";
            this.Load += new System.EventHandler(this.HotKeySetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HotKeyTargets;
        private System.Windows.Forms.TextBox HotKeyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Clear;
    }
}