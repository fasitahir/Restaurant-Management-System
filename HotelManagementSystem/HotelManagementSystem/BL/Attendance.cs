using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.UI;
using HotelManagementSystem.DL;

namespace HotelManagementSystem.BL
{
    class Attendance
    {
        private char isPresent;
        private string name;

        public Attendance(string name)
        {
            this.name = name;
        }


        public string GetName()
        {
            return this.name;
        }

        public char GetIsPresent()
        {
            return this.isPresent;
        }

        public bool SetIsPresent(char attendance)
        {
            if (attendance == 'p' || attendance == 'a' || attendance == 'P' || attendance == 'A')
            {
                isPresent = attendance;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
