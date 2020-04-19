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
using TreeTop.PLL;

namespace TreeTop
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassCha.Hide();//Pass * hide. PassChar Show
        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassCha.Show();// Pass* che PassChar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtPass.Text = txtPassCha.Text;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUser.Text;
            string pass = txtPass.Text;
            if (email.Trim() != "" && pass.Trim() != "")
            {
                AccountBLL accountbll = new AccountBLL();
                AccountDTO dto = accountbll.checkLogin(email, pass);
                if (dto != null)
                {
                    if (dto.Role.Equals("Admin"))
                    {
                        frmAdminManager frmAdminManager = new frmAdminManager(dto);
                        this.Hide();// khong Close duoc vi no la main chinh chay truoc
                        frmAdminManager.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        frmTreeShop freTreeShop = new frmTreeShop(dto);
                        this.Hide();// khong Close duoc vi no la main chinh chay truoc
                        freTreeShop.ShowDialog();
                        this.Show();
                    }




                }
                else
                {
                    errorMSG.Text = "Login Fail!!";
                }

            }
            else
            {
                if (email.Trim() == "")
                {
                    errorMSG.Text = "Enter Email";
                }
                else

                {
                    errorMSG.Text = "Enter Password";
                }

            }


        }

        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistationForm freRegis = new frmRegistationForm();
            freRegis.ShowDialog();
        }

        private void frmLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Really want to Exit?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword frmForgetPassword = new frmForgetPassword();
            frmForgetPassword.ShowDialog();
        }
    }
}
