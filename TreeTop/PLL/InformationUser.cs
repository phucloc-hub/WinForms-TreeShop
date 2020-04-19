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
    public partial class frmInformationUser : Form
    {
        private AccountDTO dto;
        public frmInformationUser()
        {
            InitializeComponent();
        }
        public frmInformationUser(AccountDTO dto):this()
        {
            this.dto = dto;
        }

        private void frmInformationUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            txtEmail.Text = dto.Email;
            txtName.Text = dto.UserName;
            txtAddress.Text = dto.Address;
            txtPhone.Text = dto.Phone;
        }
        private bool checkValidPhone(string phone)
        {
            bool check = true;
            System.Text.RegularExpressions.Regex exprPhone = new System.Text.RegularExpressions.Regex(@"^\d{3}-\d{2}-\d{4}$");

          
            if (!exprPhone.IsMatch(phone))
            {

                MessageBox.Show("Invalid Phone xxx-xx-xxxx");
                check = false;
            }
            return check;
        }
        private bool validationInfo()
        {
            bool check = true;
            
            if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("No infomation can empty!");
                check = false;
            }
            if (check == true)
            {
                if (!checkValidPhone(txtPhone.Text))
                {
                    return false;
                }
            }
            return check;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validationInfo())
            {
                string email = txtEmail.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;

                AccountBLL accountBLL = new AccountBLL();
                 if(accountBLL.UpdateAccount(email, name, address, phone))
                {
                    MessageBox.Show("Success");
                    dto.Address = address;
                    dto.UserName = name;
                    dto.Phone = phone;
                }


            }
        }
    }
}
