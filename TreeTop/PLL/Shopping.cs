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
    public partial class frmShopping : Form
    {
        public ShoppingCart cart = new ShoppingCart();
        private int rowinDex = 0;
        DataTable dtTree = new DataTable();

        public frmShopping()
        {
            InitializeComponent();
        }
        public frmShopping(ShoppingCart cart) : this()
        {
            this.cart = cart;
        }

        private void LoadData()
        {
            TreeBLL treeBLL = new TreeBLL();
            dtTree = treeBLL.gettAllTree();

            dgvShopping.DataSource = getTable(dtTree);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtView = getTable(dtTree);
            string searchValue = txtSearchUser.Text;
            TreeBLL treeBll = new TreeBLL();
            string filter = "Name LIKE '%" + searchValue + "%'";
            DataView view = dtView.DefaultView;
            view.RowFilter = filter;
            dgvShopping.DataSource = view;

        }

        private DataTable getTable(DataTable dt)
        {
            DataTable tableNew = new DataTable();
            tableNew.Columns.Add("Name", typeof(string));
            tableNew.Columns.Add("Description", typeof(string));
            tableNew.Columns.Add("Price", typeof(float));
            tableNew.Columns.Add("Quantity", typeof(int));
            tableNew.Columns.Add("CategoryID", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                string Name = row.Field<string>(0);
                string des = row.Field<string>(2);
                double price = row.Field<Double>(3);
                int quantity = row.Field<Int32>(6);
                string category = row.Field<string>(4);
                tableNew.Rows.Add(Name, des, price, quantity, category);
            }
            return tableNew;

        }
        private void dgvShopping_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;
            rowinDex = numrow;
            string Name = dgvShopping.Rows[numrow].Cells[0].Value.ToString();
            string image = "";
            foreach (DataRow row in dtTree.Rows)
            {
                if (row.Field<string>(0).Equals(Name))
                {
                    image = row.Field<string>(1);
                }
            }

            //string ImageLocation= 
            if (!string.IsNullOrEmpty(image))
            {
                try
                {
                    pictureBox1.Image = new Bitmap(Application.StartupPath + image);
                }
                catch
                {
                    pictureBox1.Image = new Bitmap(image);
                }


            }


        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (rowinDex != -1)
            {

                string Name = dgvShopping.Rows[rowinDex].Cells[0].Value.ToString();
                foreach (DataRow row in dtTree.Rows)
                {
                    if (row.Field<string>(0).Equals(Name))
                    {
                        string name = row["Name"] as string;
                        float price = float.Parse(row["Price"].ToString());
                        int quantity = 1;
                        int check = cart.AddtoCart(new OrderDTO(name, quantity, price));
                        if (check == 1)
                        {
                            MessageBox.Show("add them");
                        }
                        if (check == 2)
                        {
                            MessageBox.Show("Add new");
                        }
                    }
                }
            }


        }

        private void frmShopping_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    dtBook = bookManager.GetBooksByDataSet().Tables[0];

        //    //Khai bao cot BookID la khoa chinh
        //    dtBook.PrimaryKey = new DataColumn[] { dtBook.Columns[0] };
        //    //Them vao 1 cot SubTotal
        //    dtBook.Columns.Add("SubTotal", typeof(float),
        //        "BookQuantity*BookPrice");


        //    txtBookID.DataBindings.Clear();
        //    txtBookTitle.DataBindings.Clear();
        //    txtBookPrice.DataBindings.Clear();
        //    txtBookQuantity.DataBindings.Clear();

        //    txtBookID.DataBindings.Add("Text", dtBook, "BookID");
        //    txtBookTitle.DataBindings.Add("Text", dtBook, "BookTitle");
        //    txtBookPrice.DataBindings.Add("Text", dtBook, "BookPrice");
        //    txtBookQuantity.DataBindings.Add("Text", dtBook, "BookQuantity");

        //    dgvBookList.DataSource = dtBook;
        //}
    }
}
