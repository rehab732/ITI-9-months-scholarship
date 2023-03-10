using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Data;
using System.Configuration;
namespace Data_Access_Layer
{
    public  class DBManager
    {
        SqlConnection sqlcn;
        SqlCommand sqlcmd;
        SqlDataAdapter sqlAd;
        DataTable data;
       public DBManager()
        {
            try
            {
                sqlcn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCN"].ConnectionString);
                sqlcmd = new SqlCommand();
                sqlcmd.CommandType= CommandType.StoredProcedure;
                sqlcmd.Connection= sqlcn;
                sqlAd= new (sqlcmd);
                data=new ();
               

            }
            catch
            {

            }
        }
        //return number of rows effected
        public int ExecuteNonQuery(string spName)
        {
            try
            {


                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                    sqlcn.Open();
                return sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlcn.Close();
            }
        }
        public int ExecuteNonQuery(string spName,Dictionary<string ,object> paramlist)
        {
            try
            {


                sqlcmd.Parameters.Clear();
                foreach(var item in paramlist)
                     sqlcmd.Parameters.Add(new SqlParameter(item.Key,item.Value));
                sqlcmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                    sqlcn.Open();
                return sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                sqlcn.Close();
            }
        }
        public object ExecuteScalar(string spName)
        {
            try
            {


                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                    sqlcn.Open();
                return sqlcmd.ExecuteScalar();
            }
            catch
            {
                return new();
            }
            finally
            {
                sqlcn.Close();
            }
        }
        public object ExecuteScalar(string spName, Dictionary<string, object> paramlist)
        {
            try
            {


                sqlcmd.Parameters.Clear();
                foreach (var item in paramlist)
                    sqlcmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                sqlcmd.CommandText = spName;
                if (sqlcn.State == ConnectionState.Closed)
                    sqlcn.Open();
                return sqlcmd.ExecuteScalar();
            }
            catch
            {
                return new();
            }
            finally
            {
                sqlcn.Close();
            }
        }
        public DataTable ExecuteDataTable(string spName)
        {
            try
            {
                data.Clear();
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandText= spName;
                sqlAd.Fill(data);
                return data;


            }
            catch
            {
                return new();
            }
        }
        public DataTable ExecuteDataTable(string spName, Dictionary<string, object> paramlist)
        {
            try
            {
                data.Clear();
                sqlcmd.Parameters.Clear();
                foreach (var item in paramlist)
                    sqlcmd.Parameters.Add(new SqlParameter(item.Key, item.Value));
                sqlcmd.CommandText = spName;
                sqlAd.Fill(data);
                return data;


            }
            catch
            {
                return new();
            }
        }


    }
}