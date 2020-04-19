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
    public partial class frmBillManager : Form
    {
        private int RowIndex = 0;
        DataTable dt;
        public frmBillManager()
        {
            InitializeComponent();
        }

        private void BillManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            dt = new DataTable();
            // get Data for dt
            TransactionBLL transactionBLL = new TransactionBLL();
            dt = transactionBLL.getAllTrans();
            dgvOrder.DataSource = dt;

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int IDTrans = int.Parse(dgvOrder.Rows[RowIndex].Cells[0].Value.ToString());

            frmDetailsAdminView frmDetailsAdminView = new frmDetailsAdminView(IDTrans);
            frmDetailsAdminView.ShowDialog();
            LoadData();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            RowIndex = e.RowIndex;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            // get value from DateTimePicker , Compare if any error, use DataView
            string from = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
            string to = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
            if (DateTime.Compare(DateTime.Parse(from),DateTime.Parse( to)) > 0)
            {
                MessageBox.Show("Invalid time");
                return;
            }
            string filter = "CreateDate >= '" + from + " 00:00:00' and CreateDate <= '" + to + " 23:59:59'";
            DataView view = dt.DefaultView;
            view.RowFilter = filter;
        }
    }
}
