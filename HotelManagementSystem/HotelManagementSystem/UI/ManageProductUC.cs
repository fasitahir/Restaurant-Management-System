using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.DL;
using HotelManagementSystem.BL;

namespace HotelManagementSystem.UI
{
    public partial class ManageProductUC : UserControl
    {
        public ManageProductUC()
        {
            InitializeComponent();
            DataBind();
            InitializeKeyEvent();
            productGridView.CellClick += ProductGridView_CellClick;
            IncreaseGridViewFontSize();
        }

        private void IncreaseGridViewFontSize()
        {
          
            int fontSize = 14;

            foreach (DataGridViewColumn column in productGridView.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", fontSize, FontStyle.Regular);
            }
        }


        private void InitializeKeyEvent()
        {
            productNameTb.KeyPress += TextBox_KeyPress;
            productQuantityTb.KeyPress += TextBox_KeyPress;
            pricePerUnitTb.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the "ding" sound
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {

                DataGridViewRow clickedRow = productGridView.Rows[e.RowIndex];

                string productName = clickedRow.Cells["Name"].Value.ToString();
                string quantity = clickedRow.Cells["Quantity"].Value.ToString();
                string price = clickedRow.Cells["PricePerUnit"].Value.ToString();

                // Populate the text boxes with the data
                productNameTb.Text = productName;
                productQuantityTb.Text = quantity;
                pricePerUnitTb.Text = price;
            }
        }


        private void DataBind()
        {
            List<BL.Product> product = ProductDL.products;
            productGridView.DataSource = null;
            productGridView.DataSource = product;
            productGridView.AutoGenerateColumns = true;
            productGridView.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string productName = productNameTb.Text;
            string quantity = productQuantityTb.Text;
            string price = pricePerUnitTb.Text;

            //Validations

            bool isNameValid = Validation.NameValidation(productName);
            bool isQuantityValid = Validation.DoubleValidation(quantity, 1, 1000000000);
            bool isPriceValid = Validation.IntValidation(price, 1, 1000000000);

            if(isNameValid && isQuantityValid && isPriceValid)
            {
                
                Product p = new Product(productName, int.Parse(quantity), double.Parse(price));
                if(!ProductDL.isProductExist(p))
                {
                    ProductDL.AddToList(p);
                    ProductDL.ProductFile();
                    DataBind();
                }
                else
                {
                    MessageBox.Show("Product Already Exist");
                }
            }
            else
            {
                if(!isNameValid)
                {
                    MessageBox.Show("Name should only have letters");
                }
                else if(!isQuantityValid)
                {
                    MessageBox.Show("Quantity should only have numbers");
                }
                else if(!isPriceValid)
                {
                    MessageBox.Show("Price should not have letters or symbols");
                }
            }     
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string name = productNameTb.Text;

            bool isDeleted = ProductDL.RemoveProduct(name);
            
            if(isDeleted)
            {
                MessageBox.Show("Item has been Removed");
                ProductDL.UpdateProductFile();
                DataBind();
            }
            else
            {
                MessageBox.Show("Item not present");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            productNameTb.Clear();
            productQuantityTb.Clear();
            pricePerUnitTb.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
