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
    class Manager : Users
    {
        public void AddProduct(Product p)
        {
            if(p!=null)
            {
                ProductDL.AddToList(p);
                ProductDL.ProductFile(); // Save the products to a file or perform other operations
            }
            else
            {
            }
        }

        public int GetProductCount()
        {
            return ProductDL.products.Count;
        }

        public string GetProductNameAtIndex(int index)
        {
            return ProductDL.products[index].GetName();
        }


        public int GetProductQuantityAtIndex(int index)
        {
            return ProductDL.products[index].GetQuantity();
        }


        public double GetProductPriceAtIndex(int index)
        {
            return ProductDL.products[index].GetPricePerUnit();
        }

        public static double ManageExpensesWorker()
        {
            double totalSalaries = 0;
            foreach(Worker w in WorkerDL.workers)
            {
                totalSalaries += w.GetSalary();
            }
            return totalSalaries;
        }

        public static double ManageExpensesProduct()
        {
            double totalProduct = 0;
            foreach(Product p in ProductDL.products)
            {
                totalProduct += p.GetPricePerUnit() * p.GetQuantity();
            }

            return totalProduct;
        }

        public static double TotalExpenses(double salary, double product, double otherExpenses)
        {
            double totalExpenses = salary + product + otherExpenses;
            return totalExpenses;
        }

    }
}
