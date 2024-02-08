using HotelManagementSystem.BL;
using System;
using System.Windows.Forms;

namespace HotelManagementSystem.UI
{
    public partial class Tip_Calculator : UserControl
    {
        public Tip_Calculator()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            totalBillTb.KeyDown += TextBox_KeyDown;
            paidMoneyTb.KeyDown += TextBox_KeyDown;
            tipPercentTb.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (sender == paidMoneyTb)
                {
                    // Calculate remaining money and display it on the label
                    if (double.TryParse(totalBillTb.Text, out double totalBill) && double.TryParse(paidMoneyTb.Text, out double paidMoney))
                    {
                        double remainingMoney = totalBill - paidMoney;
                        remainingMoneyLabel.Text = $"Remaining: {remainingMoney:C}";
                    }

                    // Set focus to the tipPercentTb (3rd box)
                    tipPercentTb.Focus();
                }
                else
                {
                    // Move focus to the next control (e.g., 3rd box)
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }


        private void Tip_Calculator_Load(object sender, EventArgs e)
        {

        }

        private void giveTipBtn_Click(object sender, EventArgs e)
        {
            string totalBill = totalBillTb.Text;
            string moneyGave = paidMoneyTb.Text;
            string tip = tipPercentTb.Text;

            bool isBillValid = Validation.DoubleValidation(totalBill, 0, 1000000000);
            bool isMoneyGaveValid = Validation.DoubleValidation(moneyGave, 1, 1000000000);
            bool isTipValid = Validation.DoubleValidation(tip, 1, 100);

            if (isBillValid && isMoneyGaveValid && isTipValid)
            {
                double result = Customer.TipCalculator(float.Parse(totalBill), float.Parse(moneyGave), float.Parse(tip));
                if (result != 0)
                {
                    tipGaveLabel.Text ="Tip Gave: " + result + "";
                }
                else
                {
                    MessageBox.Show("You can not give tip");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Input");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            totalBillTb.Clear();
            paidMoneyTb.Clear();
            remainingMoneyLabel.Text = "Remaining Money: ";
            tipGaveLabel.Text = "Tip Gave: ";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
