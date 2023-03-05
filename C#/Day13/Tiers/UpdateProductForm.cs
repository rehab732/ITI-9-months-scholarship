using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiers_Demo
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            this.lblid.Text = "1";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if((int.TryParse(this.lblid.Text,out int tempid))&&(this.proName.Text?.Length>0))
            {
               var s= ProductManager.UpdateProductNameByProductID(tempid, this.proName.Text);

                this.Text = $"{s}";
            }
        }
    }
}
