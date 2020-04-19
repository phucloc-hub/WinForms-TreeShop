using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTop.DLL
{
    public class CategoryDAO
    {

        public DataTable getAll()
        {
            string sql = "select ID,Category from Category";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
        public bool insertTO(string id, string name)
        {
            string sql = "insert into Category values( @id , @name )";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { id, name }) > 0;
        }

        public bool Delete(string id)
        {
            string sql = "Delete from Category where ID = @id ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { id }) > 0;
        }
        public bool Update(string id,string name)
        {
            string sql = "Update Category set Category = @name where ID = @id ";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { name ,id}) > 0;
        }
    }
}
