using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question6;
using question8;

namespace question10
{
    internal class Supervisor : Employee
    {
		private int _subordinates;

		public Supervisor() 
		{
			Designation = "Supervisor";
		}

		public Supervisor(string name, bool gender, string address, Date birth, double salary, string designation, DepartmentType dept, int subordinates)
		{
			Name = name;
			Gender = gender;
			Address = address;
			Birth = birth;
			Salary = salary;
			Designation = "Supervisor";
			Dept = dept;
			Subordinates = subordinates;

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
            Console.Write("Subordinates: ");
            Subordinates = Convert.ToInt32((string)Console.ReadLine());
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }




        public int Subordinates
		{
			get { return _subordinates; }
			set { _subordinates = value; }
		}

        public override string ToString()
        {
			return base.ToString() + ", Subordinates " + Subordinates;
        }

    }
}
