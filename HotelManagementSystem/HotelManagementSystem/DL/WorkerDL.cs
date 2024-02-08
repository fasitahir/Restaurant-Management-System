using HotelManagementSystem.BL;
using System.Collections.Generic;
using System.IO;

namespace HotelManagementSystem.DL
{
    class WorkerDL
    {
        public static List<Worker> workers = new List<Worker>();

        public static double WorkerExpenses()
        {
            double sum = 0;
            foreach (Worker w in workers)
            {
                sum += w.Salary;
            }
            return sum;
        }

        public static void AddToList(Worker w)
        {
            workers.Add(w);
        }
        public static bool IsWorkerExist(string name, string role)
        {
            foreach (Worker w in workers)
            {
                if (w.GetName().ToLower() == name.ToLower() && w.GetRole().ToLower() == role.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool RemoveWorker(string name, string role)
        {
            foreach (Worker w in workers)
            {
                if (w.GetName().ToLower() == name.ToLower() && w.GetRole().ToLower() == role.ToLower())
                {
                    workers.Remove(w);
                    return true;
                }
            }
            return false;
        }

        public static void WorkersFile()
        {
            StreamWriter myFile = new StreamWriter("workersData.txt", true);

            myFile.WriteLine(workers[workers.Count - 1].GetName() + "," + workers[workers.Count - 1].GetRole() + "," + workers[workers.Count - 1].GetSalary() + "," + workers[workers.Count - 1].GetWorkingHours());
            myFile.Flush();
            myFile.Close();
        }

        public static void WorkersFileRead()
        {
            StreamReader myFile = new StreamReader("workersData.txt");

            string line;
            while (!myFile.EndOfStream)
            {
                line = myFile.ReadLine();
                string[] data = line.Split(',');

                string name = data[0];
                string role = data[1];
                double salary = double.Parse(data[2]);
                double workingHours = double.Parse(data[3]);
                Worker w = new Worker(name, role, salary, workingHours);
                AddToList(w);
            }
            myFile.Close();
        }

        public static void UpdateWorkerData()
        {
            StreamWriter workersData = new StreamWriter("workersData.txt");
            foreach(Worker w in workers)
            {
                workersData.WriteLine(w.GetName() + "," + w.GetRole() +","+ w.GetSalary() + "," +w.GetWorkingHours());
            }
            workersData.Flush();
            workersData.Close();
        }
    }



}