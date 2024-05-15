namespace question3
{
    internal class Program
    {

        public int menu()
        {

        }
        static void Main(string[] args)
        {
            int a, b, result, choice;
            

            do
            {

                Console.WriteLine("Enter First Number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number: ");
                b = int.Parse(Console.ReadLine());


                Console.WriteLine("0. EXIT");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Enter choice :");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("EXITING...!");
                        break;

                    case 1:
                        result = a + b;
                        Console.WriteLine("Addition");
                        Console.WriteLine(a + " + " + b + " = " + result);

                        break;

                    case 2:
                        result = a - b;
                        Console.WriteLine("Subtraction");
                        Console.WriteLine(a + " - " + b + " = " + result);

                        break;

                    case 3:
                        result = a * b;
                        Console.WriteLine("Multiplication");
                        Console.WriteLine(a + " * " + b + " = " + result);

                        break;

                    case 4:
                        result = a / b;
                        Console.WriteLine("Division");
                        Console.WriteLine(a + " / " + b + " = " + result);

                        break;

                    default:
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                }
            }while (choice != 0);   

        }
    }
}
