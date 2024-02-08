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
    public partial class AddReviewUC : UserControl
    {
        public AddReviewUC()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ServiceCB.SelectedItem == null || FoodCB.SelectedItem == null || environmentCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a rating for all categories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string serviceRatting = ServiceCB.SelectedItem.ToString();
            string foodRatting = FoodCB.SelectedItem.ToString();
            string environmentRatting = environmentCB.SelectedItem.ToString();

            Customer c = new Customer(serviceRatting, foodRatting, environmentRatting);
            CustomerDL.AddToList(c);
            CustomerDL.ReviewFile();

            MessageBox.Show("Thank you for your review! Have a nice day.");
            this.Hide();
        }

        private void ServiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
