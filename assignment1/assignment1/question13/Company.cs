using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question8;

namespace question12
{
    public class Company
    {
		private string _name;
		private string  _address;
		private double _salaryExpense;
		private LinkedList<Employee> _empList = new LinkedList<Employee>();

		public Company()
		{

		}

		public Company(string name, string address, double salaryexpense, LinkedList<Employee> empList)
		{
			_name = name;
			_address = address;
			_salaryExpense = salaryexpense;
			EmpList = empList;
		}


		public LinkedList<Employee> EmpList
		{
			get { return EmpList; }
			set { EmpList = value; }
		}


		public double SalaryExpense
		{
			get { return _salaryExpense; }
			set { _salaryExpense = value; }
		}

		public string  Address
		{
			get { return _address; }
			set { _address = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public void Accept()
		{
			Console.Write("Name: ");
			Name = Console.ReadLine();
			Console.Write("Address: ");
			Address = Console.ReadLine();
			Console.Write("Salary Expense: ");
			SalaryExpense = Convert.ToDouble(Console.ReadLine());
		}

		public void Print()
		{
			ToString();
		}

		public void AddEmployee(Employee e)
		{
			_empList.AddLast(e);
		}

		public bool RemoveEmployee(int id)
		{
			return _empList.Remove(_empList.First(e => e.Id == id));

        }

		public LinkedListNode<Employee> FindEmployee(int id)
		{
			return _empList.Find(_empList.First(e => e.Id == id));

        }

		public double CalculateSalaryExpense()
		{
			return SalaryExpense / 12;
		}

		public void PrintEmployee()
		{
			foreach(Employee e in _empList)
			{
				Console.WriteLine(e);
			}
		}
        public override string ToString()
        {
			return "Name: " + Name + ", Address: " + Address + ", Salary Expense: " + SalaryExpense;
        }

	
    }
}
