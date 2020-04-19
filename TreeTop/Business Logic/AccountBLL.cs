using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DAO;

namespace TreeTop.Business_Logic
{

    public class AccountBLL
    {


        //public bool addtoCart(AccountDTO dto)
        //{
        //    if (items.ContainsKey(dto.Email))
        //    {
        //        items.Add(dto.Email, dto);

        //    }
        //    foreach(AccountDTO valuesDTO in items.Values)
        //    {
        //        // code to add to database ORDERS TABLE
        //    }

        //    return false;
        //}
        public bool SetAsAdmin(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.SetAsAdmin(email);
        }
        public bool delete(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.Delete(email);
        }
        public DataTable getAll(string email)
        {
            AccountDAO dao = new AccountDAO();
            return dao.getAll(email);
        }
        public bool UpdateAccount(string email, string name, string address, string phone)
        {
            AccountDAO dao = new AccountDAO();

            return dao.UpdateAccount(email, name, address, phone);
        }
        public bool UpdateAccount(string email, string password)
        {
            AccountDAO dao = new AccountDAO();

            return dao.UpdateAccount(email, password);
        }
        // 
        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    // append the string result to the string
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }




        public string InsertAccount(string name, string email, string pass, string address, string phone)
        {
            AccountDAO dao = new AccountDAO();
            string role = "Member";
            if (dao.IsexistEmail(email))
            {
                return "";
            }
            else
            {
                string SecretKey = ComputeSha256Hash(address);
                dao.InsertAccount(name, email, pass.Trim(), address, phone, role,SecretKey);

                return SecretKey;
            }
        }
        public bool ForgotPassword(string email,string SecretKey)
        {
            AccountDAO dao = new AccountDAO();
            return dao.ForgotPassword(email, SecretKey);
        }
        public AccountDTO checkLogin(string email, string pass)
        {
            AccountDTO dto = null;
            try
            {
                AccountDAO dao = new AccountDAO();
                dto = dao.checkLogin(email, pass);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return dto;


        }
    }
}
