using HotelManagementSystem.DL;
using System;

namespace HotelManagementSystem.BL
{
    class Menu
    {
        private string name;
        private string price;

        public string Name { get { return name.ToUpper(); } set { name = value; } }
        public string Price { get { return price; } set { price = value; } }

        public Menu(string name, string price)
        {
            this.name = name;
            this.price = price;
        }

        public bool SetName(string name)
        {
            bool flag = NameValidation(name);
            if (flag)
            {
                this.name = name;
            }
            return flag;
        }

        public bool SetPrice(string price)
        {
            bool flag = PriceValidation(price);
            if (flag)
            {
                this.price = price;
            }
            return flag;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetPrice()
        {
            return this.price;
        }

        public static bool IsPresent(string name)
        {
            foreach (Menu n in MenuDL.menu)
            {
                if (n.GetName().ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool NameValidation(string name)
        {
            foreach (char c in name)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;

        }


        public static bool PriceValidation(string price)
        {
            bool flag = true;
            foreach (char c in price)
            {
                if (!Char.IsDigit(c))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }


        public static Menu IsItemExist(string name)
        {
            foreach (Menu m in MenuDL.menu)
            {
                if (m.GetName().ToLower() == name.ToLower())
                {
                    return m;
                }
            }
            return null;
        }

        public static int ChangeName(Menu menu)
        {
            int count = 0;
            foreach (Menu m in MenuDL.menu)
            {
                if (m.Name.ToUpper() == menu.Name.ToUpper())
                {
                    m.Price = menu.Price;
                    break;
                }
                count++;
            }
            MenuDL.MenuDataUpdate();
            return count;
        }
    }
}
