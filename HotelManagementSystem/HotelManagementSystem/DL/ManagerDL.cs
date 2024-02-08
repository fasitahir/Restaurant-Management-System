using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.BL;

namespace HotelManagementSystem.DL
{
    class ManagerDL
    {
        public static List<Attendance> attendances = new List<Attendance>();

        public static void AddToList(Attendance a)
        {
            attendances.Add(a);
        }
    }
}
