using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question6;
using question8;

namespace question11
{
    internal class WageEmp: Employee
    {
		private int	_hours;
		private int _rate;
		

		public WageEmp() 
		{
			Designation = "Wage";
		}

		public WageEmp(string name, bool gender, string address, Date birth, double salary, string designation, DepartmentType dept, int hours, int rate)
		{
			Name = name;
			Gender = gender;
			Address = address;
			Birth = birth;
			Salary = salary;
			Designation = "Wage";
			Dept = dept;
			Hours = hours;
			Rate = rate;
		}
		public int Rate
		{
			get { return _rate; }
			set { _rate = value; }
		}

		public int Hours
		{
			get { return _hours; }
			set { _hours = value; }
		}

        public override void Accept()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Gender(m or f): ");
            string g = Console.ReadLine();
            if (g == "m")
            {
                Gender = true;
            }
            else
            {
                Gender = false;
            }

            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Birth Details");
            Birth.AcceptDate();
            Console.WriteLine("Department: ");
            Console.WriteLine("1. Marketing, 2. Sales, 3. Store");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
            Console.Write("Wage Hours: ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wage Rate: ");
            Rate = Convert.ToInt32(Console.ReadLine());
            
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + ", Wage: " + Hours * Rate;
        }

    }
}
