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
    public partial class frmPasswordUpdating : Form
    {
        private AccountDTO dto;
        public frmPasswordUpdating()
        {
            InitializeComponent();
        }
        public frmPasswordUpdating(AccountDTO dto) : this()
        {
            this.dto = dto;
        }

        private bool validation()
        {
            bool check = true;

            if(string.IsNullOrWhiteSpace(txtNewP.Text) || string.IsNullOrWhiteSpace(txtOldP.Text))
            {
                MessageBox.Show("There's no infomation can empty");
                check = false;
            }
            if (check == true)
            {
                // check pass hien hanh
                if (!txtOldP.Text.Equals(dto.Password))
                {
                    MessageBox.Show("The old password is not correct!");
                    return false;
                }
            }
            return check;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (validation())
            {
                AccountBLL accountBLL = new AccountBLL();
                if(accountBLL.UpdateAccount(dto.Email, txtNewP.Text))
                {
                    MessageBox.Show("Success");
                    dto.Password = txtNewP.Text;
                    
                }

            }
        }
    }
}
