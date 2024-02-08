using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DL;

namespace HotelManagementSystem.BL
{
    class SignIn:Credentials
    {
        public string Login(string userName, string password)
        {
            Credentials c = base.IsExist(userName, password);
            
            if (c != null)
            {
                return c.GetRole();
            }
            else
            {
                return null;
            }
        }
    }
}
