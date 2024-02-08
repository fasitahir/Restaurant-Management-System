using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CashierPage : Form
    {
        public CashierPage()
        {
            InitializeComponent();
            //Hide all the user controls
            addMenuUC1.Hide();
            menuUC1.Hide();
            updateMenuUC1.Hide();
            recieveOrder1.Hide();
            viewOrders1.Hide();
            billCalculate1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addMenuUC1_Load(object sender, EventArgs e)
        {

        }

        private void addMenuB_Click(object sender, EventArgs e)
        {
            addMenuUC1.Show();
            addMenuUC1.BringToFront();
        }

        private void viewMenuB_Click(object sender, EventArgs e)
        {
            menuUC1.Show();
            menuUC1.BringToFront();
        }

        private void updateMenuB_Click(object sender, EventArgs e)
        {
            updateMenuUC1.Show();
            updateMenuUC1.BringToFront();
        }

        private void recieveOrderB_Click(object sender, EventArgs e)
        {
            recieveOrder1.Show();
            recieveOrder1.BringToFront();
        }

        private void viewOrderB_Click(object sender, EventArgs e)
        {
            viewOrders1.Show();
            viewOrders1.BringToFront();
        }

        private void billCalculateB_Click(object sender, EventArgs e)
        {
            billCalculate1.Show();
            billCalculate1.BringToFront();
        }
        //to go back to main page
        private void label1_Click(object sender, EventArgs e)
        {
            addMenuUC1.Hide();
            menuUC1.Hide();
            updateMenuUC1.Hide();
            recieveOrder1.Hide();
            viewOrders1.Hide();
            billCalculate1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addMenuUC1.Hide();
            menuUC1.Hide();
            updateMenuUC1.Hide();
            recieveOrder1.Hide();
            viewOrders1.Hide();
            billCalculate1.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addMenuUC1.Hide();
            menuUC1.Hide();
            updateMenuUC1.Hide();
            recieveOrder1.Hide();
            viewOrders1.Hide();
            billCalculate1.Hide();
        }

        private void menuUC1_Load(object sender, EventArgs e)
        {

        }

        private void updateMenuUC1_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                this.Close();
                LoginPage login = new LoginPage();
                login.Show();

            }
        }
    }
}
