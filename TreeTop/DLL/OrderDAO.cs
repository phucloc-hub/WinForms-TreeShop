using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTop.DLL
{
    public class OrderDAO
    {
        public bool insertTo(int IDTrans,string name,int quantity,float total,float price)
        {
            string sql = "Insert into [Order] values( @IDtrans , @name , @quantity , @total , @price )";
            return DataProvider.Instance.ExecuteNonQuery(sql, new object[] { IDTrans, name, quantity, total, price }) > 0;


        }

        public DataTable getOrders(int id_transaction)
        {
            string sql = "select ID,TransactionID,ProductName,Quantity,Total,Price from [Order] where TransactionID = @id ";
            return DataProvider.Instance.ExecuteQuery(sql, new object[] { id_transaction });
        }
    }
}
