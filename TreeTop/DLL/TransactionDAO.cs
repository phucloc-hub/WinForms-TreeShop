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
    public class TransactionDAO
    {
      
        public bool CancelOrdering(int IDTrans)
        {
            string status = "Cancel"; // status kinds: Cancel, Active , Approve
            string sql = "Update [Transaction] set Status = @status where IDTrans = @IDTrans ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { status, IDTrans }) > 0;
        }
        public bool insertTo(string email, float total, string createDate)
        {
            string status = "Active";
            string sql = "Insert into [Transaction] values( @email , @total , @createDate , @status )";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { email, total, createDate, status }) > 0;

        }
        public DataTable getAllTransUser(string email)
        {
            string sql = "select * from [Transaction] where Email = @email ";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { email });
        }

        public bool SetStatus(string status, int IDTrans)
        {
            string sql = "Update [Transaction] set Status = @status where IDTrans = @IDTrans ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { status, IDTrans }) > 0;
        }
        public DataTable getAllTransAdmin()
        {
            string status = "Cancel";
            string sql = "select * from [Transaction] where Status != @status ";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { status });
        }
        public int getID()
        {
            int ID = -1;
            DbUtils db = new DbUtils();


            string sql = "select COUNT(IDTrans) as ID from [Transaction] ";
            SqlConnection connection = db.getConnection();
            SqlCommand cmd = new SqlCommand(sql, connection);

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        ID = int.Parse(dr["ID"].ToString());

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
            return ID;
        }
    }
}
