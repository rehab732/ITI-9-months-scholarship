using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.EntityList;
using Business_Layer.Entity;
using Data_Access_Layer;
using System.Data;

namespace Business_Layer
{
    public class ProductManager
    {
        static DBManager manager = new();

        public static ProductList SelectAllProducts()
        {
            try
            {
                ///productlist///////datatable
                /////ezan need maping
                return (DatatableToList(manager.ExecuteDataTable("SelectAllProducts")));
            }
            catch
            {
                return new ProductList();


            }

        }

        
        internal static ProductList DatatableToList(DataTable data)
        {
            ProductList prolist = new();

            try
            {
                //Convert Each row in datatable to object in productList
                foreach(DataRow row in data.Rows)
                {
                    prolist.Add(DatarowToProduct(row));
                }
            }
            catch
            {
                return new();
            }
            return prolist;
        }
        internal static Product DatarowToProduct(DataRow row)//datarow-->proid proname category ......
        {
            Product product = new Product();
            try
            {
                //map id
                if (int.TryParse(row["ProductID"]?.ToString() ?? "-1", out int tempint))
                    product.ProductID = tempint;
                product.ProductName = row["ProductName"]?.ToString()??"NA";
                product.QuantityPerUnit = row["QuantityPerUnit"]?.ToString() ?? "NA";


                if (int.TryParse(row["SupplierID"]?.ToString() ?? "-1", out tempint))
                    product.SupplierID = tempint;

                if (int.TryParse(row["CategoryID"]?.ToString() ?? "-1", out tempint))
                    product.CategoryID = tempint;
                if (short.TryParse(row["ReorderLevel"]?.ToString()??"-1",out short tempshort))
                    product.ReorderLevel= tempshort;
                if (short.TryParse(row["UnitsInStock"]?.ToString() ?? "-1", out  tempshort))
                    product.UnitsInStock = tempshort;
                if (short.TryParse(row["UnitsOnOrder"]?.ToString() ?? "-1", out  tempshort))
                    product.UnitsOnOrder = tempshort;
                if (Decimal.TryParse(row["UnitPrice"]?.ToString()??"-1",out decimal tempdec))
                    product.UnitPrice= tempdec;
                if (bool.TryParse(row["Discontinued"]?.ToString()??"-1" , out bool tempbool))
                    product.Discontinued = tempbool;
                    
            }
            catch
            {
                return new();
            }
            return product;

        }
    }
}

