using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question7
{
    public class Person
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

        public virtual void Accept()
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
        }

        public virtual void Print()
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
            return "Name: " + Name + ", Gender: " + g + ", Address: " + Address + " Birth: " + Birth;
        }
    }


    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date()
        {

        }
        public Date(int day, int month, int year)
        {
            this._day = day;
            this._month = month;
            this._year = year;
        }


        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public void AcceptDate()
        {
            Console.Write("Day: ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month: ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine(ToString());
        }

        public bool IsValid()
        {
            if (Day > 0 && Day <= 31 && Month > 0 && Month <= 12 && Year > 1900 && Year < 3000)
                return true;
            return false;
        }


        public override string ToString()
        {
            return "Date: " + Day + "/" + Month + "/" + Year;
        }

        public static int Difference(Date d1, Date d2)
        {
            return Math.Abs(d1.Year - d2.Year);
        }


        public static int operator -(Date d1, Date d2)
        {
            return Difference(d1, d2);
        }

        
    }
}
