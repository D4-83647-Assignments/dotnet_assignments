using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question6;
using question7;
using question8;

namespace question9
{
    internal class Manager: Employee
    {
		private double _bonus;

		public Manager()
		{
			Designation = "Manager";
		}


		public Manager(string name, bool gender, string address, question7.Date birth, double salary, DepartmentType dept, double bonus)
		{
            Name = name;
			Gender = gender;
			Address = address;
			Birth = birth;
			Salary = salary;
			Designation = "Manager";
			Dept = dept;
			Bonus = bonus;
		}


		public double Bonus
		{
			get { return _bonus; }
			set { _bonus = value; }
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
            Console.Write("Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Department: ");
            Console.WriteLine("1. Marketing, 2. Sales, 3. Store");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
            Console.Write("Bonus: ");
			Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Print()
        {
			Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + ", Bonus: "+Bonus;
        }

    }
}
