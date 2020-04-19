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
using TreeTop.DAO;

namespace TreeTop.PLL
{
    public partial class frmAccountManager : Form
    {
        private int RowIndex = -1;
        AccountDTO dto;
        DataTable dt;
        public frmAccountManager()
        {
            InitializeComponent();
        }
        public frmAccountManager(AccountDTO dto) : this()
        {
            this.dto = dto;
        }


        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dt = new DataTable();

            // get dt data
            AccountBLL accountBLL = new AccountBLL();
            dt = accountBLL.getAll(dto.Email);
            //Khai bao cot Email la khoa chinh
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            dgvAccount.DataSource = dt;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (RowIndex == -1)
            {
                MessageBox.Show("Select one!");
                return;
            }
            AccountBLL accountBLL = new AccountBLL();
            string Email = dgvAccount.Rows[RowIndex].Cells[0].Value.ToString();
            if (accountBLL.SetAsAdmin(Email))
            {
                MessageBox.Show("Success");

                //delete
                DataRow r = dt.Rows.Find(Email);
                dt.Rows.Remove(r);

            }



        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (RowIndex == -1)
            {
                MessageBox.Show("Select one!");
                return;
            }
            AccountBLL accountBLL = new AccountBLL();
            string Email = dgvAccount.Rows[RowIndex].Cells[0].Value.ToString();

            if (accountBLL.delete(Email))
            {
                MessageBox.Show("Success");
                DataRow row = dt.Rows.Find(Email);
                dt.Rows.Remove(row);

            }
            else
            {
                MessageBox.Show("Cannot delete cuz foreign key ");
            }
        }
    }
}
