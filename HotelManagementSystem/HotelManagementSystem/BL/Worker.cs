using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.BL
{
    class Worker
    {
        private string name;
        private string role;
        private double salary;
        private double workingHours;

        public string Name { get { return name; } set { name = value; } }

        public string Role { get { return role; } set { role = value; } }

        public double Salary { get { return salary; } set { salary = value; } }

        public double Hours { get { return workingHours; } set { workingHours = value; } }


        public Worker(string name, string role, double salary, double workingHours)
        {
            this.name = name;
            this.role = role;
            this.salary = salary;
            this.workingHours = workingHours;
        }


        public string GetName()
        {
            return this.name;
        }

        public string GetRole()
        {
            return this.role;
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public double GetWorkingHours()
        {
            return this.workingHours;
        }

    }
}
