using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.BL;
using HotelManagementSystem.DL;
using HotelManagementSystem.UI;

namespace HotelManagementSystem.BL
{
    class Product
    {
        private string name;
        private int quantity;
        private double pricePerUnit;


        public string Name{ get { return this.name; } set { this.name = value; } }
        public int Quantity{ get { return this.quantity; } set { this.quantity = value; } }
        public  double PricePerUnit{ get { return this.pricePerUnit; } set { this.pricePerUnit = value; } }
        public Product(string name, int quantity,double pricePerUnit)
        {
            this.name = name;
            this.quantity = quantity;
            this.pricePerUnit = pricePerUnit;
        }
        public void SetName(string name)
        {
            if (Validation.NameValidation(name))
            {
                this.name = name;
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return this.quantity;
        }

        public void SetPricePerUnit(double pricePerUnit)
        {
            this.pricePerUnit = pricePerUnit;
        }

        public double GetPricePerUnit()
        {
            return this.pricePerUnit;
        }


    }
}
