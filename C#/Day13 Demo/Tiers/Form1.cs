using Business_Layer;
using Business_Layer.EntityList;
using System.Diagnostics;

namespace Tiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductList prolist;
        private void Form1_Load(object sender, EventArgs e)
        {
            prolist=ProductManager.SelectAllProducts();
            grdpro.DataSource = prolist;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in prolist)
            {
                Trace.WriteLine(item.State);
            }
        }
    }
}