using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTop.DLL;

namespace TreeTop.Cart
{
    public class ShoppingCart
    {
        public Dictionary<string, OrderDTO> items = new Dictionary<string, OrderDTO>();
        public ShoppingCart()
        {
        }
        public int AddtoCart(OrderDTO item)
        {
            int check = 0;
            if (items.ContainsKey(item.ProductName))
            {
                int quantity = 0;
                foreach (OrderDTO ite in items.Values)
                {
                    if (ite.ProductName.Equals(item.ProductName))
                    {
                        quantity = ite.Quantity;
                    }
                }

                items.Remove(item.ProductName);
                item.Quantity = quantity + 1;
                item.Total = item.Quantity * item.Price;
                // set tang 1
                items.Add(item.ProductName, item);
                check = 1;

            }
            else
            {
                check = 2;
                item.Total = item.Quantity * item.Price;
                items.Add(item.ProductName, item);
            }
            return check;
        }
        public void UpdateQuantity(string name, int quantity)
        {
            if (items.ContainsKey(name))
            {
                foreach (OrderDTO value in items.Values)
                {
                    if (value.ProductName.Equals(name))
                    {
                        if (quantity == 0)
                        {
                            items.Remove(name);
                        }
                        else
                        {
                            value.Quantity = quantity;
                            value.Total = quantity * value.Price;
                        }
                        break;
                    }
                }
            }
        }
        public void RemoveFromCart(string name)
        {
            if (items.ContainsKey(name))
            {
                items.Remove(name);
            }
            if(items.Keys == null)
            {
                items = null;
            }
        }


    }
}
