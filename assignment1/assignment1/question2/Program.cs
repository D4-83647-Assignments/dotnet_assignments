namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            int result;
            int choice = 0;

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


                string c = Console.ReadLine();

                choice = int.Parse(c);
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


        }
    }
}
