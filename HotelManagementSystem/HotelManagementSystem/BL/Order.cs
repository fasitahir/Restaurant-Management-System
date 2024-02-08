using System;
using System.Collections.Generic;
using HotelManagementSystem.DL;
namespace HotelManagementSystem.BL
{
    class Order
    {
        private string name;
        private string orderedItem;
        private int orderQuantity;

        public string Name
        {
            get { return name; } 
            set { name = value; } 
        }

        public string OrderedItem
        {
            get { return orderedItem; }
            set { orderedItem = value; }
        }

        public int OrderQuantity
        {
            get { return orderQuantity; }
            set { orderQuantity = value; }
        }

        public Order(string name)
        {
            this.name = name;
        }

        public Order(string name, string orderName, int quantity)
        {
            this.name = name;
            this.orderedItem = orderName;
            this.orderQuantity = quantity;
        }
        public bool SetName(string name)
        {
            bool flag = true;
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                this.name = name;
                return flag;
            }
            else
            {
                return flag;
            }

        }
        public string GetName()
        {
            return this.name;
        }

    }
}
