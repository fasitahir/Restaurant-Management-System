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
    public partial class WorkerExpensesUC : UserControl
    {
        public WorkerExpensesUC()
        {
            InitializeComponent();
            DataBind();
            sum();
        }

        private void DataBind()
        {
            List<Worker> workers = WorkerDL.workers;
            workerGridView.DataSource = null;
            workerGridView.DataSource = workers;
            workerGridView.AutoGenerateColumns = true;
            workerGridView.Refresh();
        }

        private void sum()
        {
            double sum = 0;

            sum = WorkerDL.WorkerExpenses();

            sumLabel.Text ="Total Expenses are: " + sum;
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
