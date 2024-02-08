using HotelManagementSystem.BL;
using System.Collections.Generic;
using System.IO;

namespace HotelManagementSystem.DL
{
    class ProductDL
    {
        public static List<Product> products = new List<Product>();

        //Search from object
        public static bool isProductExist(Product p)
        {
            foreach(Product product in products)
            {
                if(p.Name.ToLower() == product.Name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static double ProductExpenses()
        {
            double sum = 0;
            foreach (Product p in ProductDL.products)
            {
                sum += p.PricePerUnit * p.Quantity;
            }
            return sum;
        }

        public static void AddToList(Product p)
        {
            if (p != null)
            {
                products.Add(p);
            }
        }

        public static bool RemoveProduct(string name)
        {
            foreach (Product p in products)
            {
                if (name.ToLower() == p.GetName().ToLower())
                {
                    products.Remove(p);
                    return true;
                }
            }
            return false;
        }


        public static void ProductFile()
        {
            string path = "productData.txt";
            StreamWriter myFile = new StreamWriter(path, true);
            myFile.WriteLine(products[products.Count - 1].GetName() + "," + products[products.Count - 1].GetQuantity() + "," + products[products.Count-1].GetPricePerUnit());
            myFile.Flush();
            myFile.Close();
        }

        public static void ProductFileRead()
        {
            string path = "productData.txt";
            StreamReader myFile = new StreamReader(path, true);

            string line;
            while (!myFile.EndOfStream)
            {
                line = myFile.ReadLine();
                string[] data = line.Split(',');
                string name = data[0];
                int quantity = int.Parse(data[1]);
                double pricePerUnit = double.Parse(data[2]);

                Product p = new Product(name, quantity,pricePerUnit);
                
                AddToList(p);
            }
            myFile.Close();
        }

        public static void UpdateProductFile()
        {
            string path = "productData.txt";
            StreamWriter myFile = new StreamWriter(path);

            for (int i = 0; i < products.Count; i++)
            {
                myFile.WriteLine(products[i].GetName() + "," + products[i].GetQuantity() + "," + products[i].GetPricePerUnit());
            }
            myFile.Flush();
            myFile.Close();
        }


    }
}
