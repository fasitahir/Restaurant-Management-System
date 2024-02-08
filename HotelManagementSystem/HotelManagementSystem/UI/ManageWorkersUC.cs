using HotelManagementSystem.BL;
using HotelManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem.UI
{
    public partial class ManageWorkersUC : UserControl
    {
        public ManageWorkersUC()
        {
            InitializeComponent();
            DataBind();
            IncreaseGridViewFontSize();
            InitializeKeyEvent();
            workerGridView.CellClick += WorkerGridView_CellClick;
        }

        private void IncreaseGridViewFontSize()
        {

            int fontSize = 10;

            foreach (DataGridViewColumn column in workerGridView.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Arial", fontSize, FontStyle.Regular);
            }
        }


        private void InitializeKeyEvent()
        {
            workerNameTb.KeyPress += TextBox_KeyPress;
            workerRoleTb.KeyPress += TextBox_KeyPress;
            workerSalaryTb.KeyPress += TextBox_KeyPress;
            workingHoursTb.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void WorkerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow clickedRow = workerGridView.Rows[e.RowIndex];

                string workerName = clickedRow.Cells["Name"].Value.ToString();
                string workerRole = clickedRow.Cells["Role"].Value.ToString();
                string workerSalary = clickedRow.Cells["Salary"].Value.ToString();
                string workingHours = clickedRow.Cells["Hours"].Value.ToString();

                // Populate the text boxes with the data
                workerNameTb.Text = workerName;
                workerRoleTb.Text = workerRole;
                workerSalaryTb.Text = workerSalary;
                workingHoursTb.Text = workingHours;
            }
        }


        private void DataBind()
        {
            List<Worker> workers = WorkerDL.workers;
            workerGridView.DataSource = null;
            workerGridView.DataSource = workers;
            workerGridView.AutoGenerateColumns = true;
            workerGridView.Refresh();
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = workerNameTb.Text;
            string role = workerRoleTb.Text;
            string salary = workerSalaryTb.Text;
            string hours = workingHoursTb.Text;

            //Validations

            bool isNameValid = Validation.NameValidation(name);
            bool isRoleValid = Validation.NameValidation(role);
            bool isSalaryValid = Validation.DoubleValidation(salary, 1, 1000000000);
            bool isHoursValid = Validation.DoubleValidation(hours, 4, 18);

            if (isNameValid && isRoleValid && isSalaryValid && isHoursValid)
            {

                Worker w = new Worker(name, role, double.Parse(salary), double.Parse(hours));
                if (!WorkerDL.IsWorkerExist(name, role))
                {
                    WorkerDL.AddToList(w);
                    WorkerDL.WorkersFile();
                    DataBind();
                }
                else
                {
                    MessageBox.Show("Worker Already Exist");
                }
            }
            else
            {
                if (!isNameValid)
                {
                    MessageBox.Show("Name should only have letters");
                }
                else if (!isRoleValid)
                {
                    MessageBox.Show("Role should only have letters");
                }
                else if (!isSalaryValid)
                {
                    MessageBox.Show("Salary should not have letters or Symbols");
                }
                else if (!isHoursValid)
                {
                    MessageBox.Show("Working Hours should not have letters or symbols");
                }
            }
            IncreaseGridViewFontSize();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string name = workerNameTb.Text;
            string role = workerRoleTb.Text;

            bool isDeleted = WorkerDL.RemoveWorker(name, role);

            if (isDeleted)
            {
                MessageBox.Show("Worker has been Removed");
                WorkerDL.UpdateWorkerData();
                DataBind();
            }
            else
            {
                MessageBox.Show("Worker not present");
            }
            IncreaseGridViewFontSize();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            workerNameTb.Clear();
            workerRoleTb.Clear();
            workerSalaryTb.Clear();
            workingHoursTb.Clear();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
