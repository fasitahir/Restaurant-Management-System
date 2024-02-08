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
using HotelManagementSystem.DL;

namespace HotelManagementSystem
{
    public partial class RecieveOrder : UserControl
    {
        public RecieveOrder()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
            itemQuantityTB.Focus();
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            CustomerNameTB.KeyDown += TextBox_KeyDown;
            itemNameTb.KeyDown += TextBox_KeyDown;
            itemQuantityTB.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound when Enter key is pressed
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReceiveOrderB_Click(object sender, EventArgs e)
        {
            string customerName = CustomerNameTB.Text;
            string itemName = itemNameTb.Text;
            string itemQuantity = itemQuantityTB.Text;

            bool isCustNameValid = Validation.NameValidation(customerName);
            bool isItemNameValid = BL.Menu.NameValidation(itemName);
            bool isQuantityValid = Validation.IntValidation(itemQuantity);
            bool isItemPresent = BL.Menu.IsPresent(itemName);
            
            if(isCustNameValid && isItemNameValid && isItemNameValid && isItemPresent)
            {
                Order order = new Order(customerName,itemName,int.Parse(itemQuantity));
                OrderDL.orders.Add(order);
                MessageBox.Show("Order has been Recieved");
            }
            else
            {
                if(!isItemPresent)
                {
                    MessageBox.Show("Item is not available");
                }
                else if(!isCustNameValid || !isItemNameValid)
                {
                    MessageBox.Show("Name Should not have Digits or Symbols");
                }
                else if(!isQuantityValid)
                {
                    MessageBox.Show("Quantity can only be in numbers");
                }
            }

        }

        private void clearFieldB_Click(object sender, EventArgs e)
        {
            CustomerNameTB.Clear();
            itemNameTb.Clear();
            itemQuantityTB.Clear();
        }
    }
}
