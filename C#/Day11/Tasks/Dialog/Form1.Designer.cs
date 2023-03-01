namespace Dialog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.colordlg = new System.Windows.Forms.ColorDialog();
            this.fontdlg = new System.Windows.Forms.FontDialog();
            this.opendlg = new System.Windows.Forms.OpenFileDialog();
            this.savedlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.MistyRose;
            this.btnopen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnopen.Location = new System.Drawing.Point(12, 23);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(90, 42);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MistyRose;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsave.Location = new System.Drawing.Point(404, 23);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 42);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.MistyRose;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclose.Location = new System.Drawing.Point(836, 23);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 42);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnfont
            // 
            this.btnfont.BackColor = System.Drawing.Color.MistyRose;
            this.btnfont.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfont.Location = new System.Drawing.Point(402, 519);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(98, 47);
            this.btnfont.TabIndex = 3;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = false;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btncolor
            // 
            this.btncolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncolor.BackColor = System.Drawing.Color.MistyRose;
            this.btncolor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncolor.Location = new System.Drawing.Point(8, 519);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(94, 47);
            this.btncolor.TabIndex = 4;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btncust
            // 
            this.btncust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncust.BackColor = System.Drawing.Color.MistyRose;
            this.btncust.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncust.Location = new System.Drawing.Point(836, 519);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(94, 47);
            this.btncust.TabIndex = 5;
            this.btncust.Text = "Custom";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // rtxt
            // 
            this.rtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxt.Location = new System.Drawing.Point(12, 89);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(918, 393);
            this.rtxt.TabIndex = 6;
            this.rtxt.Text = "";
            // 
            // opendlg
            // 
            this.opendlg.FileName = "text.txt";
            this.opendlg.InitialDirectory = "E:";
            // 
            // savedlg
            // 
            this.savedlg.FileName = "text.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(954, 578);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.formloading);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnopen;
        private Button btnsave;
        private Button btnclose;
        private Button btnfont;
        private Button btncolor;
        private Button btncust;
        private RichTextBox rtxt;
        private ColorDialog colordlg;
        private FontDialog fontdlg;
        private OpenFileDialog opendlg;
        private SaveFileDialog savedlg;
    }
}