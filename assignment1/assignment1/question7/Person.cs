using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using question6;

namespace question7
{
    internal class Person
    {
        private string _name;
        private bool _gender;
        private Date _birth;
        private string _address;
        private int _age;

        public Person()
        {
            Birth = new Date();
        }

        public Person(string name, bool gender, string address, Date birth)
        {
            _name = name;
            _gender = gender;
            _address = address;
            _birth = birth;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public Date Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int GetAge()
        {
            Date d = new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            return Date.Difference(Birth, d);
        }

        public void Accept()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Gender(m or f): ");
            string g = Console.ReadLine();
            if(g == "m")
            {
                Gender = true;
            }
            else
            {
                Gender= false;  
            }

            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Birth Details");
            Birth.AcceptDate();
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            string g;
            if (Gender)
            {
                g = "male";
            }
            else
            {
                g = "female";
            }
            return "Name: " + Name + " Gender: " + g + " Address: " + Address + " Birth: " + Birth;
        }
    }
}
