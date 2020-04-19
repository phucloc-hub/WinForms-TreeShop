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
    public partial class frmCategoryManager : Form
    {
        private int RowIndex = 0;
        private bool clicked_Clear = false;
        DataTable dt;
        public frmCategoryManager()
        {
            InitializeComponent();
        }

        private void frmCategoryManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dt = new DataTable();
            // get data for dt
            CategoryBLL categoryBLL = new CategoryBLL();
            dt = categoryBLL.getAll();

            // binding for text boxes

            // clear first
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();

            //add binding
            txtID.DataBindings.Add("Text", dt, "ID");
            txtName.DataBindings.Add("Text", dt, "Category");

            DataView view = dt.DefaultView;
            view.Sort = "ID DESC";
            dgvCategory.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clicked_Clear = true;
            // clear first
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();

            txtID.Clear();
            txtName.Clear();

            // set to false to allow edit
            txtID.ReadOnly = false;
        }
        private bool validation()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Did you forgot to type something?");
                check = false;
            }
            if (check == true)
            {
                // check duplicated ID
                foreach (DataRow row in dt.Rows)
                {
                    string ID = row.Field<string>(0).ToString();
                    if (ID.Equals(txtID.Text))
                    {
                        MessageBox.Show("Duplicated ID");
                        return false;
                    }

                }

            }



            return check;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!clicked_Clear)
            {
                MessageBox.Show("Please Clear the text first!");
                return;
            }
            if (validation())
            {
                CategoryBLL categoryBLL = new CategoryBLL();
                if (categoryBLL.insertTo(txtID.Text, txtName.Text))
                {
                    MessageBox.Show("Success");
                }

            }


            // end
            clicked_Clear = false;
            LoadData();
            txtID.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = dgvCategory.Rows[RowIndex].Cells[1].Value.ToString();


            if (!name.Equals(txtName.Text))
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a name");
                    return;
                }
                CategoryBLL categoryBLL = new CategoryBLL();
                if (categoryBLL.Update(txtID.Text, txtName.Text))
                {
                    MessageBox.Show("Sucess");

                }
            }

            // end
            LoadData();
            txtID.ReadOnly = true;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                if (MessageBox.Show("Are you sure to delete it?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    CategoryBLL categoryBLL = new CategoryBLL();

                    if (categoryBLL.Delete(txtID.Text))
                    {
                        MessageBox.Show("Success");

                    }
                    else
                    {
                        MessageBox.Show("Cannot delete cuz foreign key ");
                    }



                }
            }
            LoadData();
        }
    }
}
