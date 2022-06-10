namespace RailMapGenerator {
    partial class SplitLine {
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
            this.Stops = new System.Windows.Forms.ListBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stops
            // 
            this.Stops.FormattingEnabled = true;
            this.Stops.ItemHeight = 15;
            this.Stops.Location = new System.Drawing.Point(12, 12);
            this.Stops.Name = "Stops";
            this.Stops.Size = new System.Drawing.Size(236, 349);
            this.Stops.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 367);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(97, 59);
            this.ok.TabIndex = 3;
            this.ok.Text = "确认";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(151, 367);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 59);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SplitLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 434);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Stops);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplitLine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择拆分车站";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Stops;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}