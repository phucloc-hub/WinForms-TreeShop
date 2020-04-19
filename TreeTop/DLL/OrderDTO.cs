using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTop.DLL
{
    public class OrderDTO
    {
        public int ID { get; }
        public int TransactionID { get;}

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }
        public float Price { get; set; }

        public OrderDTO(string productName, int quantity, float price)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}
