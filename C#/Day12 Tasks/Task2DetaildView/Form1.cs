global using Microsoft.Data.SqlClient;
global using System.Data;
using System.Configuration;

namespace Task2DetaildView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlAd;
        DataTable data;
        SqlCommand pricecmd;
        BindingSource probinding;

        SqlCommand sqlcmdcategory;
        SqlDataAdapter sqlAdcategory;
        DataTable categoryData;



        SqlCommand sqlcmdsup;
        SqlDataAdapter sqlAdsup;
        DataTable supData;


        private void Form1_Load(object sender, EventArgs e)
        {
            sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindUN"].ConnectionString);
            sqlcmd = new SqlCommand("SelectAllProducts", sqlcn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlAd=new SqlDataAdapter(sqlcmd);
            data= new DataTable();

            SqlCommandBuilder builder = new(sqlAd);
            sqlAd.InsertCommand=builder.GetInsertCommand();
            sqlAd.UpdateCommand=builder.GetUpdateCommand(); 
            sqlAd.DeleteCommand=builder.GetDeleteCommand();

            sqlAd.Fill(data);
            prolist.DataSource= data;
            prolist.DisplayMember = "ProductName";
            prolist.ValueMember = "ProductID";

            probinding= new BindingSource(data,"");
            this.proid.DataBindings.Add("Text", probinding, "ProductID");
            this.proname.DataBindings.Add("Text", probinding, "ProductName");
            this.uprice.DataBindings.Add("Text", probinding, "unitPrice");
            this.ustock.DataBindings.Add("Text", probinding, "UnitsInStock");

            sqlcmdcategory = new SqlCommand("select CategoryID as CID , CategoryName As CName from Categories", sqlcn);
            sqlAdcategory=new SqlDataAdapter(sqlcmdcategory);
            categoryData= new DataTable();
            sqlAdcategory.Fill(categoryData);


            this.categoryname.DataSource= categoryData;
            this.categoryname.DisplayMember = "CName";
            this.categoryname.ValueMember = "CID";
            this.categoryname.DataBindings.Add("SelectedValue", probinding, "CategoryID");



            sqlcmdsup = new SqlCommand("select SupplierID as SupID , CompanyName As SupName from Suppliers", sqlcn);
            sqlAdsup = new SqlDataAdapter(sqlcmdsup);
            supData = new DataTable();
            sqlAdsup.Fill(supData);


            this.supname.DataSource = supData;
            this.supname.DisplayMember = "SupName";
            this.supname.ValueMember = "SupID";
            this.supname.DataBindings.Add("SelectedValue", probinding, "SupplierID");

            BindingNavigator bindingNav = new BindingNavigator(probinding);
            this.Controls.Add(bindingNav);




            btnfirst.Click += (sender, e) => probinding.MoveFirst();
            btnnext.Click += (sender, e) => probinding.MoveNext();
            btnprev.Click += (sender, e) => probinding.MovePrevious();
            bntnlast.Click += (sender, e) => probinding.MoveLast();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlAd.Update(data);
            MessageBox.Show("Updated :)");

        }

       
    }
}