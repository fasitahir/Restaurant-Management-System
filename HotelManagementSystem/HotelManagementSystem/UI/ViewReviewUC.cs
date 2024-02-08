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
    public partial class ViewReviewUC : UserControl
    {

        int selectedIndex;
        public ViewReviewUC()
        {
            InitializeComponent();
            DataBind();
        }

        private void DataBind()
        {
            List<Customer> reviews = CustomerDL.customers;
            reviewGridView.DataSource = null;
            reviewGridView.DataSource = reviews;
            reviewGridView.AutoGenerateColumns = true;
            reviewGridView.Refresh();
        }

        private void reviewGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow clickedRow = reviewGridView.Rows[e.RowIndex];
                selectedIndex = e.RowIndex;
                string service = clickedRow.Cells["Service"].Value.ToString();
                string food = clickedRow.Cells["Food"].Value.ToString();
                string environment = clickedRow.Cells["Environment"].Value.ToString();

                foodReviewTb.Text = food;
                serviceReviewTb.Text = service;
                environmentReviewTb.Text = environment;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isDeleted = CustomerDL.DeleteReview(selectedIndex);
            if(isDeleted)
            {
                MessageBox.Show("Review has been removed");
                CustomerDL.UpdateReviewFile();
                DataBind();
            }
            else
            {
                MessageBox.Show("No review selected to delete");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            serviceReviewTb.Clear();
            foodReviewTb.Clear();
            environmentReviewTb.Clear();
        }
    }
}
