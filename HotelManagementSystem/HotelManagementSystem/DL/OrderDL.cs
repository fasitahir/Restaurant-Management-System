using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.BL;
using System.IO;

namespace HotelManagementSystem.DL
{
    class OrderDL
    {
        public static List<Order> orders = new List<Order>();

        public static void AddToList(Order o)
        {
            orders.Add(o);
        }

        public static bool RemoveOrder(string name)
        {
            bool flag = false;

            for (int i = 0; i < orders.Count; i++)
            {

                if (name == orders[i].GetName())
                {
                    flag = true;

                    orders.RemoveAt(i);
                    break;
                }
            }

            return flag;
        
        }
    }
}
