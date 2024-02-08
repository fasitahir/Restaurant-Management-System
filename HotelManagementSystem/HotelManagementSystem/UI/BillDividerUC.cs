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

namespace HotelManagementSystem.UI
{
    public partial class BillDividerUC : UserControl
    {
        public BillDividerUC()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            totalBillTb.KeyDown += TextBox_KeyDown;
            totalPeopleTb.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string totalBill = totalBillTb.Text;
            string totalPeople = totalPeopleTb.Text;

            bool isBillValid = Validation.IntValidation(totalBill, 0,1000000000);
            bool isPeopleValid = Validation.IntValidation(totalPeople, 1,1000000000);

            if(isBillValid && isPeopleValid)
            {
                float bill = Customer.BillDivider(int.Parse(totalBill), int.Parse(totalPeople));
                dividedBillLabel.Text = "Divided bill is: " + bill;
            }
            else
            {
                MessageBox.Show("Wrong Input");
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            totalBillTb.Clear();
            totalPeopleTb.Clear();
            dividedBillLabel.Text = "Divided Bill is";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
