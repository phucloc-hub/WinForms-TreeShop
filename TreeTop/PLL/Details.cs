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

namespace TreeTop.PLL
{
    public partial class frmDetails : Form
    {
        DataTable dt;
        private int id_Transaction = -1;
        public frmDetails()
        {
            InitializeComponent();
        }
        public frmDetails(int id_Transaction) : this()
        {
            this.id_Transaction = id_Transaction;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dt = new DataTable();
            // get data for dt
            OrderBLL orderBLL = new OrderBLL();
            dt = orderBLL.getOrders(id_Transaction);
            DataView view = dt.DefaultView;
            view.Sort = "ProductName DESC";
            lblTotal.Text = "Total : " + dt.Compute("SUM(Total)", "") + "$";
            dgvDetails.DataSource = view;
        }
    }
}
