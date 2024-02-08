using HotelManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HotelManagementSystem.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();

        public static void AddToList(Customer c)
        {
            customers.Add(c);
        }

        public static bool DeleteReview(int index)
        {
            if (index < customers.Count)
            {

                customers.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void ReviewFile()
        {
            string path = "Reviews.txt";

            StreamWriter myFile = new StreamWriter(path, true);
            Customer info;
            info = customers[customers.Count - 1];
            myFile.WriteLine(info.GetServiceRating() + "," + info.GetFoodRating() + "," + info.GetEnvironmentRating());

            myFile.Flush();
            myFile.Close();
        }


        public static void ReviewDatasRead()
        {
            string path = "Reviews.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                while (!myFile.EndOfStream)
                {
                    record = myFile.ReadLine();
                    string[] splitedData = record.Split(',');

                    string serviceRating = splitedData[0].Trim();
                    string foodRating = splitedData[1].Trim();
                    string environmentRating = splitedData[2].Trim();

                    Customer c = new Customer(serviceRating, foodRating, environmentRating);
                    AddToList(c);
                }

                myFile.Close();
            }
        }

        public static void UpdateReviewFile()
        {
            StreamWriter reviewData = new StreamWriter("Reviews.txt");

            foreach (Customer c in customers)
            {
                reviewData.WriteLine(c.GetServiceRating() + "," + c.GetFoodRating() + "," + c.GetEnvironmentRating());
            }
            reviewData.Flush();
            reviewData.Close();
        }

    }
}
