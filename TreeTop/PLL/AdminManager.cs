using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeTop.DAO;

namespace TreeTop.PLL
{
    public partial class frmAdminManager : Form
    {
        private AccountDTO dto;
        public frmAdminManager()
        {
            InitializeComponent();
        }
        public frmAdminManager(AccountDTO dto) : this()
        {
            this.dto = dto;
            customizeDesing();
            label1.Text = dto.UserName;
        }
        private void customizeDesing()
        {
            panelGeneral.Visible = false;
            panelBill.Visible = false;
        }
        private void HideSubMenu()
        {

          
            if (panelBill.Visible == true)
            {
                panelBill.Visible = false;
            }
            if (panelGeneral.Visible == true)
            {
                panelGeneral.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
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
            if (activeForm != null)
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

        private void btnManager_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelGeneral);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {   // code here
            openChildForm(new frmCategoryManager());
            HideSubMenu();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelBill);
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            // code here
            openChildForm(new frmTreeManager());
            HideSubMenu();
        }

        private void btnAcount_Click(object sender, EventArgs e)
        {
            // code here
            openChildForm(new frmAccountManager(dto));
            HideSubMenu();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // code here
            openChildForm(new frmBillManager());
            HideSubMenu();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
