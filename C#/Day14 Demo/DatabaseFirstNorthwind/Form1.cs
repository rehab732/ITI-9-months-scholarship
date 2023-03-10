
using DatabaseFirstNorthwind.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => context?.Dispose();
        }

        NorthwindContext context=new();
        private void Form1_Load(object sender, EventArgs e)
        {
            /* var prod = (from p in context.Products
                        where p.UnitsInStock == 0
                        select p).ToList();
             this.grd.DataSource= prod;*/
            //2 way binding
            context.Products.Load();
            this.grd.DataSource = context.Products.Local.ToBindingList();



        }
    }
}