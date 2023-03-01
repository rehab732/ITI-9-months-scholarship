namespace DemoForm
{
    partial class frmRTFNotePad
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btncust = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.colordlg = new System.Windows.Forms.ColorDialog();
            this.fontdlg = new System.Windows.Forms.FontDialog();
            this.opendlg = new System.Windows.Forms.OpenFileDialog();
            this.savedlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(694, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 29);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(11, 16);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(94, 29);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(342, 16);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 29);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncolor
            // 
            this.btncolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncolor.Location = new System.Drawing.Point(342, 409);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(94, 29);
            this.btncolor.TabIndex = 3;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnfont
            // 
            this.btnfont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnfont.Location = new System.Drawing.Point(11, 409);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(94, 29);
            this.btnfont.TabIndex = 4;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btncust
            // 
            this.btncust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncust.Location = new System.Drawing.Point(694, 409);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(94, 29);
            this.btncust.TabIndex = 5;
            this.btncust.Text = "Custom";
            this.btncust.UseVisualStyleBackColor = true;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);

            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(11, 77);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(777, 313);
            this.txt.TabIndex = 6;
            this.txt.Text = "";
            // 
            // opendlg
            // 
            this.opendlg.FileName = "testing";
            this.opendlg.InitialDirectory = "D:";
            // 
            // frmRTFNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btncust);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnclose);
            this.Name = "frmRTFNotePad";
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formclosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnclose;
        private Button btnopen;
        private Button btnsave;
        private Button btncolor;
        private Button btnfont;
        private Button btncust;
        private RichTextBox txt;
        private ColorDialog colordlg;
        private FontDialog fontdlg;
        private OpenFileDialog opendlg;
        private SaveFileDialog savedlg;
    }
}