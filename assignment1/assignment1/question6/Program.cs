namespace question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            Date d2 = new Date();
            d1.AcceptDate();
            d2.AcceptDate();
            int result = d1 - d2;
            Console.WriteLine(result);
            //date.PrintDate();
            Console.WriteLine("Is Date1 valid: " + d1.IsValid());
            Console.WriteLine("Is Date2 valid: " + d2.IsValid());
            //Console.WriteLine(date.ToString());
        }
    }
}
