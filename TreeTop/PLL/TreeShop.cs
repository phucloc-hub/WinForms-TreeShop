using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeTop.Cart;
using TreeTop.DAO;
using TreeTop.PLL;

namespace TreeTop
{
    public partial class frmTreeShop : Form
    {
        public ShoppingCart cart = new ShoppingCart();

        AccountDTO dto;
        public frmTreeShop()
        {
            InitializeComponent();
        }

        public frmTreeShop(AccountDTO dto) : this()
        {
            this.dto = dto;
            customizeDesing();
            openChildForm(new frmShopping(cart));

        }

        private void customizeDesing()
        {
            panelSubInfo.Visible = false;
            panelSubMenuDemo.Visible = false;
        }
        private void HideSubMenu()
        {
            
            if(panelSubInfo.Visible == true)
            {
                panelSubInfo.Visible = false;
            }
            if(panelSubMenuDemo.Visible == true)
            {
                panelSubMenuDemo.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }  
               

                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void btnShopping_Click(object sender, EventArgs e)
        {
            openChildForm(new frmShopping(cart));
            ShowSubMenu(panelSubMenuDemo);
            label1.Text = dto.UserName;


        }

        private void btnCartView_Click(object sender, EventArgs e)
        {
            // code here

            openChildForm(new frmMyCart(cart,dto.Email));
            HideSubMenu();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // code here


            openChildForm(new frmHistory(dto.Email));
            HideSubMenu();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubInfo);
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            // code here
            openChildForm(new frmInformationUser(dto));
            HideSubMenu();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // code here
            openChildForm(new frmPasswordUpdating(dto));
            HideSubMenu();
        }

        private void btnAboutUS_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAboutUs());
            HideSubMenu();
        }


        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTreeShop_Load(object sender, EventArgs e)
        {
            label1.Text = dto.UserName;
        }
    }
}
