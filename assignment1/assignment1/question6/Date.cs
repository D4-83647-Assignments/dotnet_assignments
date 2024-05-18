﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question6
{
    internal class Date
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
        {  get { return _day; } 
            set { _day = value; }
        }

        public int Month
        { get { return _month; }
            set {  _month = value; } }

        public int Year
        { get { return _year; }
            set { _year = value; } }

        public void AcceptDate()
        {
            Console.WriteLine("Day: ");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Day: "+Day);
            Console.WriteLine("Month: "+Month);
            Console.WriteLine("Year: "+Year);
        }

        public bool IsValid()
        {
            if(Day > 0 && Day <= 31 && Month > 0 && Month <= 12 && Year > 1900 && Year < 3000)
                return true;
            return false;
        }


        public override string ToString()
        {
            return "Day- " + Day + " Month- " + Month + " Year- " + Year;
        }

        public static int Difference (Date d1, Date d2)
        {
            return Math.Abs(d1.Year -  d2.Year);
        }


        public static int operator -(Date d1, Date d2)
        {
            return Difference(d1, d2);
        }

    }
}
