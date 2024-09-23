
using Categories;
using CSharpFundamentals;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using static Categories.PostGraduate;

internal class Program
    {
    public void DoWork()
    {
        Publisher publisher = new Publisher();

        //Hander the event (or) subscribe to event
        publisher.myEvent += (sender, e) =>
        {
            int c = e.a + e.b;
            Console.WriteLine(c);
        };

        //invoke the event
        publisher.RaiseEvent(this, 30, 40);
        publisher.RaiseEvent(this, 300, 40);
        publisher.RaiseEvent(this, 30, 900);
    }

    static void Main(string[] args)
    {

        //Create expression tree with Func
        Expression<Func<int, int>> expression = a => a * a;

        //Compile expression using Compile Method to invoke it as Delegate
        Func <int, int> mySecondDelegate = expression.Compile();

        //Execute the Method
        int result = mySecondDelegate.Invoke(10);

        Console.WriteLine(result);
    Console.ReadKey();

        Program p = new Program();
        p.DoWork();




        //create object of generic class
        MarksPrinter<GraduateStudent> mp = new MarksPrinter<GraduateStudent> ();

        mp.stu = new GraduateStudent() { Marks = 80 };
        mp.PrintMarks();
        Console.ReadLine();


        User <int, int> user1 = new User<int, int>();
        User <bool, string> user2 = new User<bool, string>();
        user1.RegistrationStatus = 100;
        user2.RegistrationStatus = false;

        user1.Age = 30;
        user2.Age = "30-40";
        //Create structure instance
        Category category = new Category(30, "Senior");


        //Initialize fields through properties
        //category.CategoryId = 20;
        //category.CategoryName = "General";

        //access methods
        Console.WriteLine($"Age user1: {user1.Age}");
        Console.WriteLine($"Age user2: {user2.Age}");
        Console.WriteLine();
        Console.WriteLine($"Registration Status user1: {user1.RegistrationStatus}");
        Console.WriteLine($"Registration Status user2: {user2.RegistrationStatus}");
        Console.WriteLine();
        Console.WriteLine(category.CategoryId);
        Console.WriteLine(category.CategoryName);
        Console.WriteLine(category.GetCategoryNameLength());
        Console.ReadLine();


    }

}

        interface Ishape
        {
            void Add(int x, int y);
        }

        class Square : Ishape
        {
            public void Add(int u, int z) 
            {
                Console.WriteLine(u+z);
            }
        }
        class Rectangle : Ishape
        {
            public void Add(int x, int y)
            {
                Console.WriteLine(x+y);
            }
        }
