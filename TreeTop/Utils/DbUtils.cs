using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTop.Utils
{
    class DbUtils
    {
        public SqlConnection getConnection()
        {
             string strConnection;
             strConnection = ConfigurationManager.ConnectionStrings["TreeShop"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnection);
            return con;
         }


    }


}
