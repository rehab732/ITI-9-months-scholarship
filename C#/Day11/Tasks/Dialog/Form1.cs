namespace Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void formloading(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            btnclose.Click += (sender,e) => this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Exit", "Exit Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            opendlg.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            opendlg.InitialDirectory = "E:";
            if(opendlg.ShowDialog()==DialogResult.OK)
            {
                rtxt.LoadFile(opendlg.FileName,(RichTextBoxStreamType)(opendlg.FilterIndex-1));
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            savedlg.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            savedlg.InitialDirectory = "E:";
            if(savedlg.ShowDialog()==DialogResult.OK)
            {
                rtxt.SaveFile(savedlg.FileName, (RichTextBoxStreamType)(savedlg.FilterIndex - 1));
            }
        }

        private void btncolor_Click(object sender, EventArgs e)
        {

            if(rtxt.SelectedText.Length>0)
            {
                colordlg.Color = rtxt.SelectionColor;
            }
            if(colordlg.ShowDialog()==DialogResult.OK)
            {
                rtxt.SelectionColor=colordlg.Color;
            }
        }

        private void btnfont_Click(object sender, EventArgs e)
        {

            if (rtxt.SelectedText.Length > 0)
            {
                fontdlg.Font = rtxt.SelectionFont;
            }
            if (fontdlg.ShowDialog() == DialogResult.OK)
            {
                rtxt.SelectionFont = fontdlg.Font;
            }
        }

        customdlg customdlg = new();
        private void btncust_Click(object sender, EventArgs e)
        {
            customdlg.UserText = "Write Here Rehab";
            if(customdlg.ShowDialog()==DialogResult.OK)
            {
                this.rtxt.AppendText(customdlg.UserText.ToUpper());
            }

        }
    }
}