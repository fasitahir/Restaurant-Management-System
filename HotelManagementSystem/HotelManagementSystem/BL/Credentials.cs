using HotelManagementSystem.DL;
using System;

namespace HotelManagementSystem.BL
{
    class Credentials
    {
        protected string userName;
        protected string password;
        protected string role;
        //Constructors
        public Credentials()
        {

        }

        public Credentials(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        //Setters
        public bool SetUserName(string userName)
        {
            bool flag = UserNameValidation(userName);
            if (flag)
            {
                this.userName = userName;
            }

            return flag;
        }

        public bool SetPassword(string password)
        {
            bool flag = PasswordValidation(password);
            if (flag)
            {
                this.password = password;
            }
            return flag;
            
        }

        public bool SetRole(string role)
        {
            bool flag = RoleValidation(role);
            if (flag)
            {
                this.role = role;
            }
            return flag;
        }

        public string GetRole()
        {
            return role;
        }

        //Getters
        public string GetUserName()
        {
            return userName;
        }

        public string GetPassword()
        {
            return password;
        }

        //.....................Other Methods.......................
        public Credentials IsExist(string userName, string password)
        {

            foreach (Credentials c in CredentialsDL.credentials)
            {
                if (c.userName == userName && c.password == password)
                {
                    return c;
                }
            }
            return null;
        }
        //Validations
        public static bool UserNameValidation(string userName)
        {
            bool flag = true;
            
            foreach (char i in userName)
            {
                if (!Char.IsLetter(i) || Char.IsSymbol(i))
                {
                    
                    flag = false;
                    break;
                }
            }
            if (userName == null || userName == "")
            {
                flag = false;
            }
            return flag;
        }
        //Validations for password
        public static bool PasswordValidation(string password)
        {
            bool hasSymbol = false;
            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    hasSymbol = true;
                }
                else if (Char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (Char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            return (hasDigit && hasLetter && hasSymbol && password.Length >5);
        }

        public static bool RoleValidation(string role)
        {
            string lowerCaseRole = role.ToLower();
            if(lowerCaseRole == "manager" || lowerCaseRole == "cashier" || lowerCaseRole == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}