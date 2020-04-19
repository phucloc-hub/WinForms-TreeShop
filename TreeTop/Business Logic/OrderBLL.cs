using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.Cart;
using TreeTop.DLL;

namespace TreeTop.Business_Logic
{
    public class OrderBLL
    {

        public DataTable getOrders(int id_transaction)
        {
            OrderDAO dao = new OrderDAO();
            return dao.getOrders(id_transaction);
        }
        public string insertTo(ShoppingCart cart,string email,float total)
        {
            string Error = "";
            TreeDAO treeDao = new TreeDAO();
            OrderDAO dao = new OrderDAO();
            Dictionary<string, OrderDTO> items = cart.items;
            bool checkEnough = true;
            foreach (OrderDTO value in items.Values)
            {
                int current_quantity = treeDao.getCurrentQuantity(value.ProductName);
                if (current_quantity == -1)
                {
                    checkEnough = false;
                }
                if (current_quantity < value.Quantity)
                {
                    Error = value.ProductName + " has only " + current_quantity + " left!";
                    checkEnough = false;
                    break;
                }



            }


            // Bill Du het so luong trong kho
            if (checkEnough == true)
            {
                TransactionBLL tranBLL = new TransactionBLL();

                // save to Transaction Table
                 tranBLL.insertTo(email, total, DateTime.Now.ToString());

                // get total Transaction to get ID first


                int ID = tranBLL.getId();



                foreach (OrderDTO value in items.Values)
                {

                    dao.insertTo(ID, value.ProductName, value.Quantity, value.Total, value.Price);
                    treeDao.updateQuantity(value.ProductName, value.Quantity);

                }
                items.Clear();
            }
            return Error;
        }

    }
}
