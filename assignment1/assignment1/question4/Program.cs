namespace question4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student("Shejul", true, 19, 9, 'A', 50);

            Student student1 = new Student();
            //Default constructor is provided by Compiler
            student1.AcceptDetails();
            student1.PrintDetails();

            //Default access specifier in Structure is Public 

            /*Console.WriteLine(student.Name);
            Console.WriteLine(student.Gender);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Std);
            Console.WriteLine(student.Div);
            Console.WriteLine(student.Marks);*/




        }
    }

    public struct Student
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._std = std;
            this._div = div;
            this._marks = marks;
        }

        public double Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }


        public char Div
        {
            get { return _div; }
            set { _div = value; }
        }


        public int Std
        {
            get { return _std; }
            set { _std = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public void AcceptDetails()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Gender(True or False): ");
            Gender = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Std: ");
            Std = Convert.ToInt32(Console.ReadLine());
            Console.Write("Div: ");
            Div = Convert.ToChar(Console.ReadLine());
            Console.Write("Marks: ");            
            Marks = Convert.ToDouble(Console.ReadLine());

        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Gender(True or False): "+Gender);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Std: "+Std);
            Console.WriteLine("Div: "+Div);
            Console.WriteLine("Marks: "+Marks);
        }


    }
}
