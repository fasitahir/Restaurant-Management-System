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
    public partial class TotalExpensesUC : UserControl
    {
        double sum = 0;
        public TotalExpensesUC()
        {
            InitializeComponent();
            ShowLabel();
            otherExpensesTb.KeyDown += otherExpensesTb_KeyDown;
        }

        private void AddExpenses()
        {
            string other = otherExpensesTb.Text;

            bool isOtherValid = Validation.DoubleValidation(other, 1, 1000000000);
            if (isOtherValid)
            {
                sum += double.Parse(other);
                otherExpensesTb.Text = "";
            }
            else
            {
                MessageBox.Show("Expenses can't be letters or empty spaces");
            }
        }


        public void ShowLabel()
        {
            double productSum = ProductDL.ProductExpenses();
            double workerSum = WorkerDL.WorkerExpenses();
            productExpenses.Text = "Total Expenses on Products: " + productSum;
            workerExpenses.Text = "Total Expenses on Workers: " + workerSum;
            otherExpenses.Text = "Total Other Small Expenses: " + sum;

            double total = sum + productSum + workerSum;

            TotalExpenses.Text = "Overall Total Expenses: " + total;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddExpenses();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowLabel();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            otherExpensesTb.Clear();
        }

        private void otherExpensesTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddExpenses();
                e.SuppressKeyPress = true; // Suppress the Enter key press from being processed further
            }
        }
    }
}
