global using Microsoft.Data.SqlClient;
global using System.Data;
using System.Configuration;

namespace Task1GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare Connection
        SqlConnection sqlcn;

        //For Products
        SqlCommand sqlcmdproducts;
        SqlDataAdapter sqlAdproducts;
        DataTable products_data;

        //For Category
        SqlCommand sqlcmdcategory;
        SqlDataAdapter sqlAdCategory;
        DataTable Category_data;

        //For Suppliers
        SqlCommand sqlcmdsuppliers;
        SqlDataAdapter sqlAdSuppliers;
        DataTable Suppliers_data;
        

    
       
        private void Form1_Load(object sender, EventArgs e)
        {

            sqlcn= new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindUN"].ConnectionString);
            sqlcmdproducts = new SqlCommand("Select * from Products",sqlcn);
            sqlAdproducts = new SqlDataAdapter(sqlcmdproducts);
            products_data = new DataTable();

            //Category
            sqlcmdcategory = new SqlCommand("select CategoryID as CID,CategoryName as CName from Categories", sqlcn);
            sqlAdCategory=new SqlDataAdapter(sqlcmdcategory);
            Category_data=new DataTable();


            //suppliers
            sqlcmdsuppliers = new SqlCommand("select SupplierID as SupID , CompanyName As SupName from Suppliers", sqlcn);
            sqlAdSuppliers = new SqlDataAdapter(sqlcmdsuppliers);
            Suppliers_data = new DataTable();
            //crud
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlAdproducts);
            sqlAdproducts.InsertCommand = commandBuilder.GetInsertCommand();
            sqlAdproducts.UpdateCommand = commandBuilder.GetUpdateCommand();
            sqlAdproducts.DeleteCommand = commandBuilder.GetDeleteCommand();
            #region Test Something


            //sqlAdSuppliers.Fill(Suppliers_data);
            //datagrid.DataSource = products_data;


            /*sqlAdCategory.Fill(Category_data);
            datagrid.DataSource = products_data;
            DataGridViewComboBoxColumn category = new();

            category.DataSource = Category_data;
            category.DisplayMember = "CName";
            category.ValueMember = "CID";
            category.HeaderText = "Category";
            category.DataPropertyName = "CategoryID";//Category and category Id connected 

            datagrid.Columns.Add(category);

            datagrid.Columns[0].ReadOnly= true;//can't update id 
                                               // datagrid.Columns["CategoryID"].Visible = false;                                    
                                               //datagrid.EndEdit();
                                               //Suppliers

            

            DataGridViewComboBoxColumn suppliers = new();

            suppliers.DataSource = Category_data;
            suppliers.DisplayMember = "SupName";
            suppliers.ValueMember = "SupID";
            suppliers.HeaderText = "Supplier Name";
            suppliers.DataPropertyName = "SupplierID";


            datagrid.Columns.Add(suppliers);

            datagrid.Columns["SupplierID"].ReadOnly = true;*/

            #endregion

        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            sqlAdproducts.Fill(products_data);
            sqlAdCategory.Fill(Category_data);
            sqlAdSuppliers.Fill(Suppliers_data);
            DataGridViewComboBoxColumn category = new();
            DataGridViewComboBoxColumn suppliers = new();
            category.DataSource = Category_data;
            category.DisplayMember = "CName";
            category.ValueMember = "CID";
            category.DataPropertyName = "CategoryID";
            category.HeaderText = "Category Name";

            suppliers.DataSource = Suppliers_data;
            suppliers.DisplayMember = "SupName";
            suppliers.ValueMember = "SupID";
            suppliers.DataPropertyName = "SupplierID";
            suppliers.HeaderText = "Supplier Name";
            this.datagrid.DataSource = products_data;
            datagrid.Columns.Add(category);
            datagrid.Columns.Add(suppliers);
            datagrid.Columns[0].ReadOnly= true;


        }

        private void savedata_Click(object sender, EventArgs e)
        {
            datagrid.EndEdit();
            sqlAdproducts.Update(products_data);
            Form1_Load(this,EventArgs.Empty);
            datagrid.DataSource = null;
            LoadData_Click(this, EventArgs.Empty);
            MessageBox.Show("Data Saved Successfully");
        }
    }
}