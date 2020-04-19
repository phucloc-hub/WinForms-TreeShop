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
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
            panelSub.Visible = false;

        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            panelSub.Visible = false;

        }


        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSecretKey.Text))
            {
                MessageBox.Show("Enter required information");
                return;
            }
            AccountBLL accountBLL = new AccountBLL();
            if (accountBLL.ForgotPassword(txtEmail.Text, txtSecretKey.Text))
            {
                panelSub.Visible = true;
                txtEmail.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Incorrect information");
                if (panelSub.Visible == true)
                {
                    panelSub.Visible = false;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter new password");
                return;
            }
            AccountBLL accountBLL = new AccountBLL();
            if (accountBLL.UpdateAccount(txtEmail.Text, txtNewPassword.Text))
            {
                MessageBox.Show("Glad to see you back!");
                this.Close();
            }
        }
    }
}
