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

namespace HotelManagementSystem
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
            InitializeTextBoxEvents();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound when Enter key is pressed
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void InitializeTextBoxEvents()
        {
            // Attach the KeyDown event handler to each textbox
            userNameTb.KeyDown += TextBox_KeyDown;
            passwordTb.KeyDown += TextBox_KeyDown;
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {
            
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTb.Text;
            
            string password = passwordTb.Text;
            string role = roleTB.Text;

            bool isNameValid = Credentials.UserNameValidation(userName);
            bool isPasswordValid = Credentials.PasswordValidation(password);
            bool isRoleValid = Credentials.RoleValidation(role);

            if (isNameValid && isPasswordValid && isRoleValid)
            {
                SignUp user = new SignUp();

                if(user.LogUp(userName, password, role))
                {
                    MessageBox.Show("User Registered Successfuly", "SignUp successful", MessageBoxButtons.OK);
                    Credentials c = new Credentials(userName, password, role);
                    CredentialsDL.AddToList(c);
                    CredentialsDL.CredentialsFile();
                }
                else
                {
                    MessageBox.Show( "User with this name and password is already present.", "SignUp Failed", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                if(isNameValid == false)
                {
                    MessageBox.Show("User Name should not have spaces or symbols", "Invalid UserName ",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                    userNameTb.Focus();
                }
                else if(isPasswordValid == false)
                {
                    MessageBox.Show( "Password should have atleast 1 symbol and letter and it should have minmum length 6", "Invalid Password", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    passwordTb.Focus();
                }
                else
                {
                    MessageBox.Show( "Role can only be 'Manager', 'Cashier' and 'Customer'", "Invalid Role ", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    roleTB.Focus();
                }

            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTb.PasswordChar = '\0';
            }
            else
            {
                passwordTb.PasswordChar = '*';
            }
        }

        private void clearField_Click(object sender, EventArgs e)
        {
            userNameTb.Clear();
            passwordTb.Clear();
            roleTB.Clear();
        }
    }
}
