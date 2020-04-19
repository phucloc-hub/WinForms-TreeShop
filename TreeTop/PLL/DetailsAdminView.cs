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
    public partial class frmDetailsAdminView : Form
    {
        private int IDTrans=0;
        DataTable dt;
        public frmDetailsAdminView()
        {
            InitializeComponent();
        }
        public frmDetailsAdminView(int IDTrans):this()
        {
            this.IDTrans = IDTrans;
        }

        private void DetailsAdminView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dt = new DataTable();

            // get data for dt
            OrderBLL orderBLL = new OrderBLL();
            dt = orderBLL.getOrders(IDTrans);
            DataView view = dt.DefaultView;
            view.Sort = "Quantity DESC";

            dgvDetails.DataSource = dt;

        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            TransactionBLL transactionBLL = new TransactionBLL();
            if (transactionBLL.SetStatus("Delivering",IDTrans))
            {
                MessageBox.Show("Delevering");

            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cong lai so luong trong bang tree
            TreeBLL treeBLL = new TreeBLL();
            foreach(DataRow row in dt.Rows)
            {
                string name = row.Field<string>(2).ToString();
                int quantity = int.Parse(row.Field<int>(3).ToString());
                treeBLL.IncreaseQuantity(name, quantity);
            }
            TransactionBLL transactionBLL = new TransactionBLL();
            if (transactionBLL.SetStatus("Cancel", IDTrans))
            {
                MessageBox.Show("Cancel");
            }
            this.Close();
        }
    }
}
