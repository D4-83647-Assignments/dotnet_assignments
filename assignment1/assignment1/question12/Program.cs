using question8;

namespace question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<Employee> list = new LinkedList<Employee>();
            Company company = new Company();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee1.Accept();
            employee2.Accept();
            //employee3.Accept();
            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            //company.AddEmployee(employee3);
           
               Console.WriteLine(company.FindEmployee(employee1.Id).Value.ToString());
               Console.ReadLine();
            


            //company.PrintEmployee();

            //if(company.RemoveEmployee(employee1.Id))
            //{
            //    Console.WriteLine("Employeed "+employee1.Name+" removed Successfully !");
            //}
            //else
            //{
            //    Console.WriteLine("Employeed no removed fail");
            //}




            Console.ReadLine();
        }
    }
}
