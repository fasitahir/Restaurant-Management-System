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

namespace HotelManagementSystem
{
    public partial class UpdateMenuUC : UserControl
    {
        int indexRow;
        public UpdateMenuUC()
        {
            InitializeComponent();
            menuGridView.CellClick += dataGridView1_CellClick;
            menuGridView.DataError += dataGridView1_DataError;
            DataBind();
            InitializeTextBoxEvents();

        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            itemNameTb.KeyDown += TextBox_KeyDown;
            itemPriceTb.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound when Enter key is pressed
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMenuUC_Load(object sender, EventArgs e)
        {
            /*List<BL.Menu> menu = MenuDL.menu;
            menuGridView.DataSource = menu;
            menuGridView.AutoGenerateColumns = true;*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*            indexRow = e.RowIndex;
            DataGridViewRow row = menuGridView.Rows[indexRow];
            itemNameTb.Text = row.Cells[0].Value.ToString();
            itemPriceTb.Text = row.Cells[1].Value.ToString();*/

            indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < menuGridView.Rows.Count)
            {
                DataGridViewRow row = menuGridView.Rows[indexRow];
                itemNameTb.Text = row.Cells[0].Value.ToString();
                itemPriceTb.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                // Reset the TextBoxes when clicking outside the valid rows
                itemNameTb.Clear();
                itemPriceTb.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearFieldB_Click(object sender, EventArgs e)
        {
            itemNameTb.Clear();
            itemPriceTb.Clear();
        }

        private void addItemB_Click(object sender, EventArgs e)
        {
            string name = itemNameTb.Text;
            string price = itemPriceTb.Text;
            if(BL.Menu.IsPresent(name))
            {
                if(BL.Menu.PriceValidation(price))
                {
                    BL.Menu item = new BL.Menu(name, price);
                    indexRow = BL.Menu.ChangeName(item);
                    menuGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Price can only be integer");
                }
            }
            else
            {
                MessageBox.Show("Menu does not have item of this name");
            }
            
        }


        private void DataBind()
        {
            menuGridView.DataSource = null;
            menuGridView.DataSource = MenuDL.menu;
            menuGridView.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*DataBind();*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string itemName = itemNameTb.Text;
            BL.Menu m = BL.Menu.IsItemExist(itemName);
            if (m != null)
            {
                MenuDL.menu.Remove(m);
                MenuDL.MenuDataUpdate();
                menuGridView.Refresh();
            }
            else
            {
                MessageBox.Show("Menu does not have item of this name");
            }
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; // Cancel the error to avoid showing the default error dialog
        }
    }
}
