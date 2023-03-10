using Business_Layer;
using Business_Layer.Entity;
using Business_Layer.EntityList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiers_Demo
{
    public partial class BindForm : Form
    {
        public BindForm()
        {
            InitializeComponent();
        }

        ProductList prolist;
        BindingNavigator b;
        private void BindForm_Load(object sender, EventArgs e)
        {
            prolist = ProductManager.SelectAllProducts();
            bindsource.DataSource = prolist;
            lblproid.DataBindings.Add("Text", bindsource, "ProductID");
            txtproname.DataBindings.Add("Text", bindsource, "ProductName");

            unitinstock.DataBindings.Add("Text", bindsource, "UnitsInStock");

           b=new BindingNavigator(bindsource);
            this.Controls.Add(b);
            bindsource.AddingNew += (sender, e) => e.NewObject = new Product() { State = EntityState.Added, UnitsInStock = 1 };


        }

        private void btnnn_Click(object sender, EventArgs e)
        {
            bindsource.EndEdit();
            foreach (var item in prolist)
                Trace.WriteLine(item.State);
        }
    }
}
