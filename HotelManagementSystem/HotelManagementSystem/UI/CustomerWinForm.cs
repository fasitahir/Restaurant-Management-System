using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.UI
{
    public partial class CustomerWinForm : Form
    {
        public CustomerWinForm()
        {
            InitializeComponent();
            menuUC1.Hide();
            addReviewUC1.Hide();
            billDividerUC1.Hide();
            tip_Calculator1.Hide();
        }

        private void CustomerWinForm_Load(object sender, EventArgs e)
        {

        }

        private void viewMenuBtn_Click(object sender, EventArgs e)
        {
            menuUC1.Show();
            menuUC1.BringToFront();
        }

        private void AddReviewBtn_Click(object sender, EventArgs e)
        {
            addReviewUC1.Show();
            addReviewUC1.BringToFront();
        }

        private void billDividerBtn_Click(object sender, EventArgs e)
        {
            billDividerUC1.Show();
            billDividerUC1.BringToFront();
        }

        private void tipCalculatorBtn_Click(object sender, EventArgs e)
        {
            tip_Calculator1.Show();
            tip_Calculator1.BringToFront();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void menuUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
