using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.DL;
using HotelManagementSystem.BL;

namespace HotelManagementSystem.UI
{
    public partial class ProductExpenses_UC : UserControl
    {
        public ProductExpenses_UC()
        {
            InitializeComponent();
            DataBind();
            sum();
        }

        private void DataBind()
        {
            List<Product> product = ProductDL.products;
            productGridView.DataSource = null;
            productGridView.DataSource = product;
            productGridView.AutoGenerateColumns = true;
            productGridView.Refresh();
        }

        private void sum()
        {
            double sum = 0;
            
            sum = ProductDL.ProductExpenses();

            sumLabel.Text = "Total Expenses are: " + sum; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataBind();
            sum();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
