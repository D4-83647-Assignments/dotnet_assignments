namespace question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person();
            p.Accept();
            Console.WriteLine(p);
            Console.WriteLine("Age: "+p.GetAge());

        }
    }
}
