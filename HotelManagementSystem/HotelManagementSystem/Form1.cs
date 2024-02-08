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
using HotelManagementSystem.UI;

namespace HotelManagementSystem
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            CredentialsDL.CredentialsFileRead();
            MenuDL.MenuDataRead();
            CustomerDL.ReviewDatasRead();
            ProductDL.ProductFileRead();
            WorkerDL.WorkersFileRead();
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            userNameTb.KeyDown += TextBox_KeyDown;
            passwordTb.KeyDown += TextBox_KeyDown;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SignIn c = new SignIn();

            string userName = userNameTb.Text;
            string password = passwordTb.Text;

            if(string.IsNullOrEmpty(userName)|| string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string role = c.Login(userName, password);
                if(role!= null)
                {
                    if(role.ToLower() == "cashier")
                    {
                        CashierPage cashierPage = new CashierPage();
                        cashierPage.Show();
                        this.Hide();
                    }
                    if(role.ToLower() == "customer")
                    {
                        CustomerWinForm customerPage = new CustomerWinForm();
                        customerPage.Show();
                        this.Hide();
                    }
                    if(role.ToLower() == "manager")
                    {
                        ManagerPage managerPage = new ManagerPage();
                        managerPage.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("incorrect username or password.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound when Enter key is pressed
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(showPassword.Checked)
            {
                passwordTb.PasswordChar = '\0';
            }
            else
            {
                passwordTb.PasswordChar = '*';
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.Show();
        }

        private void clearField_Click(object sender, EventArgs e)
        {
            userNameTb.Clear();
            passwordTb.Clear();
        }
    }
}
