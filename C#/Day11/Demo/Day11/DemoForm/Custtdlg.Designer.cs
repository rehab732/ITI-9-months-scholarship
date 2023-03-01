namespace DemoForm
{
    partial class Custtdlg
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
            this.btncan = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.apendtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncan
            // 
            this.btncan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncan.Location = new System.Drawing.Point(230, 199);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(94, 29);
            this.btncan.TabIndex = 2;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(12, 199);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 29);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // apendtxt
            // 
            this.apendtxt.Location = new System.Drawing.Point(63, 91);
            this.apendtxt.Name = "apendtxt";
            this.apendtxt.Size = new System.Drawing.Size(207, 27);
            this.apendtxt.TabIndex = 0;
            // 
            // Custtdlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 242);
            this.Controls.Add(this.apendtxt);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Custtdlg";
            this.Text = "Custom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncan;
        private Button btnok;
        private TextBox apendtxt;
    }
}