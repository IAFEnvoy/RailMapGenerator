namespace RailMapGenerator {
    partial class ModifyVariable {
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
            this.variableValue = new System.Windows.Forms.TextBox();
            this.variableName = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variableValue
            // 
            this.variableValue.Location = new System.Drawing.Point(12, 37);
            this.variableValue.Name = "variableValue";
            this.variableValue.Size = new System.Drawing.Size(320, 25);
            this.variableValue.TabIndex = 0;
            this.variableValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VariableValue_KeyPress);
            // 
            // variableName
            // 
            this.variableName.AutoSize = true;
            this.variableName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.variableName.Location = new System.Drawing.Point(12, 9);
            this.variableName.Name = "variableName";
            this.variableName.Size = new System.Drawing.Size(64, 25);
            this.variableName.TabIndex = 1;
            this.variableName.Text = "Name";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(252, 68);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 45);
            this.OK.TabIndex = 2;
            this.OK.Text = "确认";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ModifyVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 121);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.variableName);
            this.Controls.Add(this.variableValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyVariable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改参数";
            this.Load += new System.EventHandler(this.ModifyVariable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variableValue;
        private System.Windows.Forms.Button OK;
        public System.Windows.Forms.Label variableName;
    }
}