using HotelManagementSystem.DL;
using System.Linq;

namespace HotelManagementSystem.BL
{
    class Cashier : Users
    {
        Menu menu;

        public void AddMenu(string name, string price)
        {
            this.menu = new Menu(name, price);
            MenuDL.AddToList(menu);
            MenuDL.MenuFile();
        }

        public static float BillCalculator(string billItemName , int quantityBill)
        {
            float bill = 0.0F;

            foreach (Menu m in MenuDL.menu)
            {
                if (m.GetName().ToLower() == billItemName.ToLower() )
                {
                    bill = quantityBill * int.Parse(m.GetPrice());
                    break;
                }
            }

            return bill;

        }
    }
}
