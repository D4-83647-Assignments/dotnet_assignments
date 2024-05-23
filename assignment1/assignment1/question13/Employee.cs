using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question7;

namespace question8
{
    public class Employee : Person
    {
        private int _id;
        private double _salary;
        private string _designation;
        private DepartmentType _dept;
        private static int idGenerator = 1001;


        public Employee()
        {
            Id = idGenerator++;
        }

        public Employee(string name, bool gender, string address, Date birth, double salary, string designation, DepartmentType dept)
        {
            Id = idGenerator++;
            Name = name;
            Gender = gender;
            Address = address;
            Birth = birth;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public DepartmentType Dept
        {
            get { return _dept; }
            set { _dept = value; }
        }

        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }

        public virtual void Accept()
        {
            base.Accept();
            Console.Write("Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Designation: ");
            Designation = Console.ReadLine();
            Console.WriteLine("Department: ");
            Console.WriteLine("1. Marketing, 2. Sales, 3. Store");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());

        }

        public virtual void Print()
        {
           
            Console.WriteLine(ToString());
            
        }

        public override string ToString()
        {
            return base.ToString() + ", Id: "+Id+", Salary: " + Salary + ", Designation: " + Designation + ", Department: " + Dept;
        }

    }

    public enum DepartmentType
    {
        Marketing = 1,
        Sales = 2,
        Store = 3
    }
}
