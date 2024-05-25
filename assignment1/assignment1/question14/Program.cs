using System.Reflection;
using question12;
using question8;

namespace question14
{
    internal class Program
    {
        public static int Menu(int choice)
        {
            Console.WriteLine("0. EXIT");
            Console.WriteLine("1. Add Employee to Company");
            Console.WriteLine("2. Remove Employee from Company");
            Console.WriteLine("3. Find Employee by Id");
            Console.WriteLine("4. Display Company Info");
            Console.WriteLine("5. Display All Employee");
            return choice;
        }
        static void Main(string[] args)
        {
            int choice = 0;


        }

        
    }
}
