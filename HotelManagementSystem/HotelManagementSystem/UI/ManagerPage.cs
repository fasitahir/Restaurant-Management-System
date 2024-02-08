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
    public partial class ManagerPage : Form
    {
        public ManagerPage()
        {
            InitializeComponent();
            hideSubMenu();
            manageProductUC1.Hide();
            manageWorkersUC1.Hide();
            viewReviewUC1.Hide();
            productExpenses_UC1.Hide();
            workerExpensesUC1.Hide();
            totalExpensesUC1.Hide();
        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manageProductUC1.Show();
            manageProductUC1.BringToFront();
        }

        private void workerBtn_Click(object sender, EventArgs e)
        {
            manageWorkersUC1.Show();
            manageWorkersUC1.BringToFront();
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            viewReviewUC1.Show();
            viewReviewUC1.BringToFront();
        }

        private void reviewBtn_Click_1(object sender, EventArgs e)
        {
            viewReviewUC1.Show();
            viewReviewUC1.BringToFront();
        }

        private void hideSubMenu()
        {
            expensesPanel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
                
        }

        private void productExpensesBtn_Click(object sender, EventArgs e)
        {
            productExpenses_UC1.Show();
            productExpenses_UC1.BringToFront();
            hideSubMenu();
        }

        private void expensesBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(expensesPanel);
        }

        private void workersExpensesBtn_Click(object sender, EventArgs e)
        {
            workerExpensesUC1.Show();
            workerExpensesUC1.BringToFront();
            hideSubMenu();
        }

        private void totalExpensesBtn_Click(object sender, EventArgs e)
        {
            totalExpensesUC1.Show();
            totalExpensesUC1.BringToFront();
            hideSubMenu();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage login = new LoginPage();
            login.Show();
        }
    }
}
