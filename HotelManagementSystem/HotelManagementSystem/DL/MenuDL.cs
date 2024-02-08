using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.BL;
using System.IO;

namespace HotelManagementSystem.DL
{
    class MenuDL
    {
        public static List<Menu> menu = new List<Menu>();

        public static void AddToList(Menu m)
        {
            menu.Add(m);
        }

        public static void MenuFile()
        {
            string path = "MenuData.txt";

            StreamWriter myFile = new StreamWriter(path, true);
            Menu info;
            info = menu[menu.Count - 1];
            myFile.WriteLine(info.GetName() + "," + info.GetPrice());

            myFile.Flush();
            myFile.Close();
        }


        public static void MenuDataRead()
        {
            string path = "MenuData.txt";
            string record;
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                while (!myFile.EndOfStream)
                {
                    record = myFile.ReadLine();
                    string[] splitedData = record.Split(',');
                    string name = splitedData[0];
                    string price = splitedData[1];
                    if(Menu.NameValidation(name) && Menu.PriceValidation(price))
                    {
                        Menu m = new Menu(name,price);
                        AddToList(m);
                    }
                    
                }
                
                myFile.Close();
            }
        }


        public static void MenuDataUpdate()
        {
            string path = "menuData.txt"; ;
            StreamWriter myFile = new StreamWriter(path);
            foreach(Menu m in menu)
            {
                myFile.WriteLine(m.GetName() + "," + m.GetPrice());
            }
            myFile.Flush();
            myFile.Close();

        }
    }
}
