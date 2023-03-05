using Business_Layer;
using Business_Layer.EntityList;

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
    }
}