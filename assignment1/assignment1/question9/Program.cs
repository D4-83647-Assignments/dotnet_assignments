using question7;
using question8;

namespace question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager m = new Manager();

            //m.Accept();
            //m.Print();

            //Employee employee = new Employee();
            //employee.Accept();
            //employee.Print();

            Person person = new Manager();
            Manager m = (Manager)person;

            m.Accept();
            m.Print();
        }
    }
}
