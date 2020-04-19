using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DLL;
using TreeTop.Utils;

namespace TreeTop.DAO
{

    public class AccountDAO
    {


        public bool SetAsAdmin(string email)
        {
            string role = "Admin";
            string sql = "Update Account set Role = @role where Email = @email ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { role, email }) > 0;
        }
        public bool Delete(string email)
        {
            string sql = "Delete from Account where Email = @email ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { email }) > 0;
        }
        public DataTable getAll(string email)
        {
            string role = "Member";
            string sql = "select Email, Name, Password, Role, Address, Phone from Account where Role = @role and Email != @email ";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { role, email });
        }
        public bool IsexistEmail(string email)
        {
            string querry = "Select * from Account where Email = @email ";
            return DataProvider.Instance.ExecuteQuery(querry, new object[] { email }).Rows.Count > 0;
        }
        public bool InsertAccount(string name, string email, string pass, string address, string phone, string role, string SecretKey)
        {
            string queryy = "Insert into Account values( @email , @name , @password , @role , @address , @phone , @SecretKey )";
            return DataProvider.Instance.ExecuteNonQuery(queryy, new object[] { email, name, pass, role, address, phone, SecretKey }) > 0;
        }
        public bool ForgotPassword(string email, string secretKey)
        {
            bool result = false;
            DbUtils dbUtils = new DbUtils();
            string sql = "select * from Account where email = @email and SecretKey = @SecretKey ";
            SqlConnection connection = dbUtils.getConnection();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@SecretKey", secretKey);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    result = true;
                }
            }
            catch
            {
                throw new Exception("e");
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public bool UpdateAccount(string email, string name, string address, string phone)
        {
            string sql = "Update Account set Name = @name , Address = @address , Phone = @phone where Email = @email ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { name, address, phone, email }) > 0;
        }
        public bool UpdateAccount(string email, string password)
        {
            string sql = "Update Account set Password = @password where Email = @email ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { password, email }) > 0;
        }



        public AccountDTO checkLogin(string userEmail, string password)
        {
            DbUtils db = new DbUtils();
            AccountDTO dto = null;

            SqlConnection con = db.getConnection();
            String sql = "select Email,Name,Password,Role,Address,Phone from Account where Email=@Mail and Password=@Pass";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Mail", userEmail);
            cmd.Parameters.AddWithValue("Pass", password);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dynamic accountDTO = new AccountDTO
                        {
                            Email = dr["Email"].ToString(),
                            Address = dr["Address"].ToString(),
                            Password = dr["Password"].ToString(),
                            Phone = dr["Phone"].ToString(),
                            UserName = dr["Name"].ToString(),
                            Role = dr["Role"].ToString()


                        };
                        dto = accountDTO;

                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dto;

        }



    }
}
