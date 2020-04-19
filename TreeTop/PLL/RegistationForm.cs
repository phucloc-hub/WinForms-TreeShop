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

namespace TreeTop
{
    public partial class frmRegistationForm : Form
    {
        public frmRegistationForm()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private bool checkValidData(string email, string phone)
        {
            bool check = true;
            System.Text.RegularExpressions.Regex exprEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            System.Text.RegularExpressions.Regex exprPhone = new System.Text.RegularExpressions.Regex(@"^\d{3}-\d{2}-\d{4}$");

            if (!exprEmail.IsMatch(email))
            {
                MessageBox.Show("Invalid Email!!");
                check = false;
            }
            else if (!exprPhone.IsMatch(phone))
            {

                MessageBox.Show("Invalid Phone xxx-xx-xxxx");
                check = false;
            }
            return check;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;

            if (user.Trim() != "" && pass.Trim() != "" && email.Trim() != "" && address.Trim() != "" && phone.Trim() != "")
            {
                if (checkValidData(email, phone))
                {


                    AccountBLL bll = new AccountBLL();
                    string secretkey = bll.InsertAccount(user, email, pass, address, phone);
                    if (!secretkey.Equals(""))// got SecretKey from AccountBLL
                    {
                        MessageBox.Show("Wellcome to join with us");
                        MessageBox.Show("Please prepare a note to save the Secretkey . We only provide it one time");
                        lblSecretKey.Text = "Your SecretKey :";
                        txtSecretKey.Text = secretkey;
                        txtSecretKey.Show();
                    }
                    else
                    {
                        MessageBox.Show("Duplicated Email");
                    }
                }


            }
            else
            {
                MessageBox.Show("Pls provide us your basic infomation!");
            }


        }
    }
}
