using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.BL;

namespace HotelManagementSystem
{
    public partial class AddMenuUC : UserControl
    {
        public AddMenuUC()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            itemNameTextBox.KeyDown += TextBox_KeyDown;
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

        private void addItemB_Click(object sender, EventArgs e)
        {
            string itemName = itemNameTextBox.Text;
            string itemPrice = itemPriceTb.Text;

            bool isNameValid =  BL.Menu.NameValidation(itemName) && (itemName != null && itemName != "");
            bool isPriceValid = BL.Menu.PriceValidation(itemPrice) && (itemPrice != null && itemPrice != "");
            bool isItemExist = (BL.Menu.IsItemExist(itemName) != null);

            if(isNameValid && isPriceValid && !isItemExist)
            {
                Cashier c = new Cashier();
                c.AddMenu(itemName, itemPrice);
                MessageBox.Show("Menu Item has been added","Menu Item Added", MessageBoxButtons.OK);
            }
            else
            {
                if(!isNameValid)
                {
                    MessageBox.Show("Menu Item name should not have Digits","Invalid Name",MessageBoxButtons.OK);
                    itemNameTb.Focus();                
                }    
                else if(!isPriceValid)
                {
                    MessageBox.Show("Menu Item price should not have Letters or symbols","Invalid Price",MessageBoxButtons.OK);
                    itemPriceTb.Focus();
                }
                else if(isItemExist)
                {
                    MessageBox.Show("Menu Item Already Present ","Already Exist",MessageBoxButtons.OK);
                    itemNameTextBox.Focus();                

                }

            }
        }

        private void clearFieldB_Click(object sender, EventArgs e)
        {
            itemNameTextBox.Clear();
            itemPriceTb.Clear();
        }
    }
}
