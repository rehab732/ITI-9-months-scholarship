using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form1 frm1= new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if((txtname.Text=="Rehab")&&(txtpass.Text=="1234"))
            {
                this.Hide();
                frm1.Show();
                this.Visible=true;
            }
        }
    }
}
