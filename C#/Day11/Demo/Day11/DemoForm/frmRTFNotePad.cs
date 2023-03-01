using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class frmRTFNotePad : Form
    {
        public frmRTFNotePad()
        {
            InitializeComponent();
        }

       

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to close", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            opendlg.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            if (opendlg.ShowDialog() == DialogResult.OK)
                switch(opendlg.FilterIndex)
                {
                    case 1:
                        txt.LoadFile(opendlg.FileName,RichTextBoxStreamType.RichText);
                        break;
                        case 2:
                        txt.LoadFile(opendlg.FileName,RichTextBoxStreamType.PlainText);

                        break;


                }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            savedlg.Filter= "Rich Text Files|*.rtf|Text Files|*.txt";
            savedlg.InitialDirectory = "D:";
            if(savedlg.ShowDialog()==DialogResult.OK)
                txt.SaveFile(savedlg.FileName,(RichTextBoxStreamType)(savedlg.FilterIndex-1));
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            if(txt.SelectedText.Length>0)
               fontdlg.Font = txt.SelectionFont;

            if (fontdlg.ShowDialog()==DialogResult.OK)
            {
                txt.SelectionFont= fontdlg.Font;
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if (txt.SelectedText.Length > 0)
                  fontdlg.Color = txt.SelectionColor;

            if (colordlg.ShowDialog()==DialogResult.OK)
            {

                txt.SelectionColor= colordlg.Color;
            }
        }

        Custtdlg custtdlg= new Custtdlg();
        private void btncust_Click(object sender, EventArgs e)
        {
            custtdlg.UserText = "Write Here Text";
            if(custtdlg.ShowDialog()==DialogResult.OK)
            {
                this.txt.AppendText(custtdlg.UserText.ToUpper());

            }
        }
    }
}
