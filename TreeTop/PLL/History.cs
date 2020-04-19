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
    public partial class frmHistory : Form
    {
        private int RowIndex = 0;
        private string email = "";
        DataTable dt;
        public frmHistory()
        {
            InitializeComponent();
        }
        public frmHistory(string email) : this()
        {
            this.email = email;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dt = new DataTable();
            // load dt from database
            TransactionBLL transactionBLL = new TransactionBLL();
            dt = transactionBLL.getAllTrans(email);
            //Khai bao cot IDTrans la khoa chinh
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            DataView view = dt.DefaultView;
            view.Sort = "CreateDate DESC";

            dgvHistory.DataSource = view;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id_Transaction = Int32.Parse(dgvHistory.Rows[RowIndex].Cells[0].Value.ToString());
            // Call frmDetails and pass id_Transaction into
            frmDetails frmDetails = new frmDetails(id_Transaction);
            frmDetails.ShowDialog();
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // save lai selected row Index 
            RowIndex = e.RowIndex;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int IDTrans = int.Parse(dgvHistory.Rows[RowIndex].Cells[0].Value.ToString());
            DataRow row = dt.Rows.Find(IDTrans);
            string status = row.Field<string>(4).ToString();
            if (status.Equals("Active")) // neu status eq 'Active' means Admin has not approve yet. - > allow cancel
            {
                if (MessageBox.Show("Are you really want to cancel :( ", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // Cong lai so luong trong bang tree
                    TreeBLL treeBLL = new TreeBLL();
                    OrderBLL orderBLL = new OrderBLL();
                    DataTable dtOrders = new DataTable();
                    dtOrders = orderBLL.getOrders(IDTrans);

                    foreach (DataRow r in dtOrders.Rows)
                    {
                        string name = r.Field<string>(2).ToString();
                        int quantity = int.Parse(r.Field<int>(3).ToString());
                        treeBLL.IncreaseQuantity(name, quantity);
                    }


                    // update database and update table
                    TransactionBLL transactionBLL = new TransactionBLL();
                    if (transactionBLL.CancelOrdering(IDTrans))
                    {
                        MessageBox.Show("Canceled!");
                        row["Status"] = "Cancel";
                        dgvHistory.Refresh();

                    }

                }


            }
            else if(status.Equals("Delivering"))
            {
                MessageBox.Show("Cannot cancel your order cuz it's delivering");
            }
            else
            {
                MessageBox.Show("It's alreadly canceled");
            }

        }
    }
}
