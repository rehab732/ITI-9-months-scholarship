namespace Dialog
{
    partial class customdlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.custclose = new System.Windows.Forms.Button();
            this.custok = new System.Windows.Forms.Button();
            this.custtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // custclose
            // 
            this.custclose.BackColor = System.Drawing.SystemColors.Info;
            this.custclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.custclose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custclose.Location = new System.Drawing.Point(28, 208);
            this.custclose.Name = "custclose";
            this.custclose.Size = new System.Drawing.Size(113, 52);
            this.custclose.TabIndex = 3;
            this.custclose.Text = "Close";
            this.custclose.UseVisualStyleBackColor = false;
            // 
            // custok
            // 
            this.custok.BackColor = System.Drawing.SystemColors.Info;
            this.custok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.custok.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custok.Location = new System.Drawing.Point(267, 208);
            this.custok.Name = "custok";
            this.custok.Size = new System.Drawing.Size(109, 52);
            this.custok.TabIndex = 1;
            this.custok.Text = "OK";
            this.custok.UseVisualStyleBackColor = false;
            // 
            // custtext
            // 
            this.custtext.Location = new System.Drawing.Point(80, 90);
            this.custtext.Name = "custtext";
            this.custtext.Size = new System.Drawing.Size(275, 27);
            this.custtext.TabIndex = 0;
            this.custtext.Text = "Enter Text";
            // 
            // customdlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 290);
            this.ControlBox = false;
            this.Controls.Add(this.custtext);
            this.Controls.Add(this.custok);
            this.Controls.Add(this.custclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "customdlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button custclose;
        private Button custok;
        private TextBox custtext;
    }
}