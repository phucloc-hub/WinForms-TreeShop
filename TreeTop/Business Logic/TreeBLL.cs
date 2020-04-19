using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DLL;

namespace TreeTop.Business_Logic
{
    public class TreeBLL
    {
        TreeDAO dao = new TreeDAO();
        public DataTable gettAllTree()
        {

            return dao.getAllTree();
        }
        public bool DeteleTree(string name)
        {
            return dao.DeleteTree(name);
        }
        public bool CreateTree(string name, string image, string description, float price, string categoryID, int quantity)
        {
            return dao.CreateTree(name, image, description, price, categoryID, quantity);
        }
        public bool UpdateTree(string name, string image, string description, float price, string categoryID, int quantity)
        {
            string status = "Active";
            return dao.updateTree(name, image, description, price, categoryID, status, quantity);
        }
        public void IncreaseQuantity(string name, int quantity)
        {
            dao.IncreaseQuantity(name, quantity);
        }
    }
}
