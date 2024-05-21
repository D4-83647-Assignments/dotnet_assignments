using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question6;
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


		public Manager(string name, bool gender, string address, Date birth, double salary, string designation, DepartmentType dept, double bonus)
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
            base.Accept();
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
