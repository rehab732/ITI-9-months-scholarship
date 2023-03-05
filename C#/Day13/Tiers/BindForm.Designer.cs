namespace Tiers_Demo
{
    partial class BindForm
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
            this.components = new System.ComponentModel.Container();
            this.unitinstock = new System.Windows.Forms.NumericUpDown();
            this.txtproname = new System.Windows.Forms.TextBox();
            this.lblproid = new System.Windows.Forms.Label();
            this.bindsource = new System.Windows.Forms.BindingSource(this.components);
            this.btnnn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unitinstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindsource)).BeginInit();
            this.SuspendLayout();
            // 
            // unitinstock
            // 
            this.unitinstock.Location = new System.Drawing.Point(325, 196);
            this.unitinstock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.unitinstock.Name = "unitinstock";
            this.unitinstock.Size = new System.Drawing.Size(150, 27);
            this.unitinstock.TabIndex = 0;
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(325, 136);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(125, 27);
            this.txtproname.TabIndex = 1;
            // 
            // lblproid
            // 
            this.lblproid.AutoSize = true;
            this.lblproid.Location = new System.Drawing.Point(325, 79);
            this.lblproid.Name = "lblproid";
            this.lblproid.Size = new System.Drawing.Size(50, 20);
            this.lblproid.TabIndex = 2;
            this.lblproid.Text = "label1";
            // 
            // btnnn
            // 
            this.btnnn.Location = new System.Drawing.Point(102, 155);
            this.btnnn.Name = "btnnn";
            this.btnnn.Size = new System.Drawing.Size(94, 29);
            this.btnnn.TabIndex = 3;
            this.btnnn.Text = "Save";
            this.btnnn.UseVisualStyleBackColor = true;
            this.btnnn.Click += new System.EventHandler(this.btnnn_Click);
            // 
            // BindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnn);
            this.Controls.Add(this.lblproid);
            this.Controls.Add(this.txtproname);
            this.Controls.Add(this.unitinstock);
            this.Name = "BindForm";
            this.Text = "BindForm";
            this.Load += new System.EventHandler(this.BindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitinstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindsource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown unitinstock;
        private TextBox txtproname;
        private Label lblproid;
        private BindingSource bindsource;
        private Button btnnn;
    }
}