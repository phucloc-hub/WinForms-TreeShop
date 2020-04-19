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
    public partial class frmTreeManager : Form
    {
        private string imageURl = "";
        DataTable dtTree;
        DataTable dtCategory;
        private bool clicked_btnClear = false;
        public frmTreeManager()
        {
            InitializeComponent();
        }

        //private Image ResizeImage(Image image,Size newSize)
        //{
        //    Image newImage = new Bitmap(newSize.Width, newSize.Height);
        //    using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
        //    {
        //        GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
        //    }
        //    return newImage;
        //}
        //private Size Size = new Size(100,100);

        /*
         * OpenFileDialog open = new ...
         * if(open.Showdialog() == DialogResult.OK){
         * Image image= bitmap.fromfile(open.FileName)
         * image= ResizeImage(image,this.Size);
         * }
         */


        private void btnImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);

                // image file path  
                imageURl = open.FileName;
            }
        }

        private void frmTreeManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            dtTree = new DataTable();
            dtCategory = new DataTable();

            // get data for 2 table
            TreeBLL treeBLL = new TreeBLL();
            dtTree = treeBLL.gettAllTree();
            CategoryBLL categoryBLL = new CategoryBLL();
            dtCategory = categoryBLL.getAll();

            //Khai bao cot BookID la khoa chinh
            dtTree.PrimaryKey = new DataColumn[] { dtTree.Columns[0] };

            //binding to ComboBox : complex binding
            cbCatageryName.DataSource = dtCategory;
            cbCatageryName.DisplayMember = "Category";
            cbCatageryName.ValueMember = "ID";

            //Binding GridView voi ComboBox
            cbCatageryName.DataBindings.Clear();
            cbCatageryName.DataBindings.Add("SelectedValue", dtTree, "CategoryID");

            //binding to DataGridView : Complex Binding 
            dgvTree.DataSource = dtTree;

            //Binding to TextBoxes: Simple Binding
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDescription.DataBindings.Clear();

            // Picture box duoc bat su kien o cellClick cua dgvTree


            txtDescription.DataBindings.Add("Text", dtTree, "Description");
            txtName.DataBindings.Add("Text", dtTree, "Name");
            txtPrice.DataBindings.Add("Text", dtTree, "Price");
            txtQuantity.DataBindings.Add("Text", dtTree, "Quantity");
        }

        private void dgvTree_CellClick(object sender, DataGridViewCellEventArgs e)
        {   // if clicked_btnClear == true =>  don't event when user click a row of dgvTree , == true means user's editting
            // --> no need to do event
            if (clicked_btnClear == false)
            {
                int numrow;
                numrow = e.RowIndex;
                string Image = dgvTree.Rows[numrow].Cells[1].Value.ToString();

                if (!string.IsNullOrEmpty(Image))
                {
                    try
                    {
                        pictureBox1.Image = new Bitmap(Application.StartupPath + Image);
                    }
                    catch
                    {
                        pictureBox1.Image = new Bitmap(Image);
                    }



                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDescription.DataBindings.Clear();

            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();

            cbCatageryName.DataBindings.Clear();

            txtName.ReadOnly = false;
            clicked_btnClear = true;
            // set to true to allow Add, Update, Delete

        }
        private bool validationUpdate()
        {

            bool check = true;
            if (string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text)
                || string.IsNullOrWhiteSpace(imageURl)
              )
            {

                MessageBox.Show("Pls fill all the fields");
                check = false;

            }
            //////////////////////////////////////
            if (check == true)
            {
                try
                {
                    float price = float.Parse(txtPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Price must be a float number");
                    check = false;
                }

                try
                {
                    int Quantity = int.Parse(txtQuantity.Text);
                    if (Quantity <= 0)
                    {
                        MessageBox.Show("Quantity must be a positive number and greater than 0");
                        check = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Quantity must be a positive number and greater than 0");
                    check = false;
                }

            }




            return check;
        }
        private bool ValidationData()
        {
            bool check = true;
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text)
                || string.IsNullOrWhiteSpace(imageURl)
              )
            {

                MessageBox.Show("Pls fill all the fields");
                check = false;

            }

            if (check == true)
            {
                // check duplicated name
                foreach (DataRow row in dtTree.Rows)
                {
                    string nameD = row.Field<string>(0).ToString();
                    if (nameD.Equals(txtName.Text))
                    {
                        MessageBox.Show("Duplicated Name!");
                        return false;
                    }
                }

                try
                {
                    float price = float.Parse(txtPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Price must be a float number");
                    check = false;
                }

                try
                {
                    int Quantity = int.Parse(txtQuantity.Text);
                    if (Quantity <= 0)
                    {
                        MessageBox.Show("Quantity must be a positive number and greater than 0");
                        check = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Quantity must be a positive number and greater than 0");
                    check = false;
                }
            }
            return check;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!clicked_btnClear)
            {
                MessageBox.Show("Pls Clear the data first to use Add function");
                return;
            }
            if (ValidationData())
            {
                TreeBLL treeBLL = new TreeBLL();
                string categoryId = cbCatageryName.SelectedValue.ToString();
                bool check = treeBLL.CreateTree(txtName.Text, imageURl, txtDescription.Text, float.Parse(txtPrice.Text), cbCatageryName.SelectedValue.ToString(), int.Parse(txtQuantity.Text));
                if (check)
                {
                    MessageBox.Show("Success");
                    LoadData();
                    clicked_btnClear = false;
                    imageURl = "";

                }
            }
            txtName.ReadOnly = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // nhan vao name -> delete
            TreeBLL treeBLL = new TreeBLL();
            if (treeBLL.DeteleTree(txtName.Text))
            {
                MessageBox.Show("Success");


                if (!clicked_btnClear)
                {
                    //delete
                    DataRow r = dtTree.Rows.Find(txtName.Text);
                    dtTree.Rows.Remove(r);
                }
                else
                {
                    LoadData();
                    clicked_btnClear = false;
                }

            }
            else
            {
                MessageBox.Show("Cannot delete cuz foreign key ");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (validationUpdate())
            {
                TreeBLL treeBLL = new TreeBLL();
                string name = txtName.Text;
                string description = txtDescription.Text;
                int quantity = int.Parse(txtQuantity.Text);
                float price = float.Parse(txtPrice.Text);
                string catagoryid = cbCatageryName.SelectedValue.ToString();
                string image = imageURl;

                if (treeBLL.UpdateTree(name, image, description, price, catagoryid, quantity))
                {
                    if (!clicked_btnClear)
                    {
                        // update table

                        DataRow row = dtTree.Rows.Find(name);
                        row["Image"] = image;
                        row["Description"] = description;
                        row["Price"] = price;
                        row["CategoryID"] = catagoryid;
                        row["Status"] = "Active";
                        row["Quantity"] = quantity;

                        dgvTree.Refresh();
                        MessageBox.Show("Save successful");
                    }
                    else
                    {
                        LoadData();
                        clicked_btnClear = false;


                    }


                }

            }

        }
    }
}
