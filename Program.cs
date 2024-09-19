
using Categories;
using CSharpFundamentals;
using System.Reflection.PortableExecutable;
using static Categories.PostGraduate;

internal class Program
    {
    static void DoWork()
    {
        //create object using "using declaration"
        using Sample s = new Sample();
        {
            s.DisplayDataFromDatabase();
        }
    }

    static void Main(string[] args)
    {
        //create obj of Subscriber class
        SubScriber subscriber = new SubScriber();

        //Create obj of Publisher class
        Publisher publisher = new Publisher();

        //Hander the event (or) subscribe to event
        publisher.myEvent += (a , b) =>
        {
            int c = a + b;
            Console.WriteLine(c);
        };

        //invoke the event
        publisher.RaiseEvent(10, 50);

        //handle the event (or) subscribe the event
        publisher.myEvent += delegate (int a, int b)
        {
            Console.WriteLine(a / b);
        };

        publisher.RaiseEvent(30, 40);
        publisher.RaiseEvent(300, 40);
        publisher.RaiseEvent(30, 900);

        Sample s = new Sample();

        MyDelegate myDelegate;

        //add ref of first method
        myDelegate = s.Add;

        //add ref of second method
        myDelegate += s.Multiply;

        myDelegate.Invoke(30, 40);
        myDelegate.Invoke(300, 40);
        myDelegate.Invoke(30, 900);

        DoWork();


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
