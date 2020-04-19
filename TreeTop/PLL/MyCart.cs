using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeTop.Business_Logic;
using TreeTop.Cart;
using TreeTop.DLL;

namespace TreeTop.PLL
{
    public partial class frmMyCart : Form
    {
        ShoppingCart cart = new ShoppingCart();
        private DataTable dt;
        private int rowIndex = -1;
        private string email = "";

        public frmMyCart()
        {
            InitializeComponent();
        }
        public frmMyCart(ShoppingCart cart, string email) : this()
        {
            this.cart = cart;
            this.email = email;
            LoadData();
            lblError.Visible = false;
        }


        public void LoadData()
        {
            dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(float));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Total", typeof(float));
            Dictionary<string, OrderDTO> items = cart.items;
            foreach (OrderDTO dto in items.Values)
            {
                string name = dto.ProductName;
                float price = dto.Price;
                int quantity = dto.Quantity;
                float total = dto.Total;
                dt.Rows.Add(name, price, quantity, total);
            }

            lblTotal.Text = "Total: " + dt.Compute("SUM(Total)", "") + "$";
            dgvCart.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                string Name = dgvCart.Rows[rowIndex].Cells[0].Value.ToString();
                cart.RemoveFromCart(Name);
                //update UI
                LoadData();
            }


        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            rowIndex = numrow; // set to rowinDex ensure clicked to dgvCart
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (rowIndex != -1)
            {
                try
                {
                    int quantity = int.Parse(txtQuantity.Text);
                }
                catch
                {
                    MessageBox.Show("Quantity must be a positive number");
                    return;
                }
                if (txtQuantity.Text.Trim() != "")
                {
                    int quantity = int.Parse(txtQuantity.Text);
                    if (quantity >= 0)
                    {
                        string Name = dgvCart.Rows[rowIndex].Cells[0].Value.ToString();
                        cart.UpdateQuantity(Name, quantity);
                        MessageBox.Show("Update successfull");
                    }
                }
                // update UI 
                LoadData();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cart.items.Count != 0)
            {
                bool check = false;

                // save total parameter
                float total = float.Parse(dt.Compute("SUM(Total)", "").ToString());

                // save to Order Table
                OrderBLL orderBLL = new OrderBLL();
                string error = orderBLL.insertTo(cart,email,total);
                if (error.Trim().Length != 0)
                {
                    lblError.Visible = true;
                    lblError.Text = error;


                }
                else
                {
                    MessageBox.Show("Thank you for your ordering ^^ ");
                }
               
            }
        }
    }
}
