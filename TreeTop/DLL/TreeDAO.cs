using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.Utils;

namespace TreeTop.DLL
{
    public class TreeDAO
    {

        public DataTable getAllTree()
        {
            string querry = "select * from Tree";
            return DataProvider.Instance.ExecuteQuery(querry);
        }

        public bool DeleteTree(string name)
        {
            string sql = "Delete from Tree where Name = @name ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { name }) > 0;
        }

        public bool updateTree(string name,string image,string description,float price,string categoryID,string status,int quantity)
        {   
            
            string sql = "Update Tree set Image = @image , Description = @description , Price = @price , CategoryID = @categoryID , Status = @status , Quantity = @quantity where Name = @name ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { image, description, price, categoryID, status, quantity, name }) > 0;
        }
        
        public bool CreateTree(string name, string image, string description, float price, string categoryID, int quantity)
        {
            string status = "Active";
            string sql = "insert into Tree values( @name , @image , @description , @price , @categoryID , @status , @quantity )";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { name, image, description, price, categoryID, status, quantity }) > 0;
        }

        public int getCurrentQuantity(string name)
        {
            int quantity = -1;
            DbUtils db = new DbUtils();
            string sql = "select Quantity from Tree where Name = @name ";
            SqlConnection connection = db.getConnection();

            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@name", name);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        quantity = int.Parse(dr["Quantity"].ToString());

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return quantity;
        }
        public void updateQuantity(string name, int quantity)
        {
            string sql = "Update Tree set Quantity = Quantity - @quantity_buy where Name = @name ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { quantity, name });
        }

        public void IncreaseQuantity(string name, int quantity)
        {
            string sql = "Update Tree set Quantity = Quantity + @quantity_buy where Name = @name ";
            DataProvider.Instance.ExecuteNonQuery(sql, new object[] { quantity, name });
        }

    }
}
