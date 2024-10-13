
using Categories;
using CSharpFundamentals;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using static Categories.PostGraduate;
using College;
using Company;

public class Program
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


    /// <summary>
    /// main class
    /// </summary>
    static void Main()
    {
        //Creating a queue object
        Console.WriteLine("Creating a queue object\n");
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Task 3");
        queue.Enqueue("Task 4");
        queue.Enqueue("Task 6");
        queue.Enqueue("Task 2");
        queue.Enqueue("Task 7");
        queue.Enqueue("Task 1");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        queue.Dequeue();
        Console.WriteLine();

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }



        //Create a collection
        IEnumerable<string> listMessages;
        listMessages = new List<string>() { "How are you","Have you ever gone to Texas","Or have you ever visited the United states?","You will sooner than you expect it and you will enjoy the visits","You will be going regularly."};

        //foreach Loop
        Console.WriteLine("\nIEnumerable:");
        foreach(string item in listMessages) Console.WriteLine(item);

        //IEnumarator
        Console.WriteLine("\n IEnumarator:");
        IEnumerator<string> enumeratorMessages = listMessages.GetEnumerator();
        enumeratorMessages.Reset();
        while(enumeratorMessages.MoveNext())
        {
            Console.WriteLine(enumeratorMessages.Current);
        }
        

        Console.ReadLine();
        //Creating Many to one relationship
        //Three employee in same department
        GoogleEmployee employee1 = new GoogleEmployee() { EmployeeId = 1, EmployeeName = "Scotty", Email = "scotty@gmail.com" };
        GoogleEmployee employee2 = new GoogleEmployee() { EmployeeId = 2, EmployeeName = "Freddy", Email = "freddy@gmail.com" };
        GoogleEmployee employee3 = new GoogleEmployee() { EmployeeId = 3, EmployeeName = "Betty", Email = "betty@gmail.com" };

        //create object of department class
        Department department = new Department() { DepartmentId = 1, DepartmentName = "Engineering Department"};
        employee1.dept = department;
        employee2.dept = department;
        employee3.dept = department;

        Console.WriteLine("Employee 1: \n - Id:  " + employee1.EmployeeId + "\n - Name: " + employee1.EmployeeName + "\n - Employee Email: " + employee1.Email+ "\n - Department Id: " + employee1.dept.DepartmentId+"\n - Department Name: "+ employee1.dept.DepartmentName);

        Console.WriteLine("Employee 2: \n - Id:  " + employee2.EmployeeId + "\n - Name: " + employee2.EmployeeName + "\n - Employee Email: " + employee2.Email+ "\n - Department Id: " + employee2.dept.DepartmentId+"\n - Department Name: "+ employee2.dept.DepartmentName);

        Console.WriteLine("Employee 3: \n - Id:  " + employee3.EmployeeId + "\n - Name: " + employee3.EmployeeName + "\n - Employee Email: " + employee3.Email+ "\n - Department Id: " + employee3.dept.DepartmentId+"\n - Department Name: "+ employee3.dept.DepartmentName);

        Console.ReadLine();


        //Creat object of Student class
        College.Student student = new College.Student();
        student.RollNo = 1;
        student.StudentName = "Allen";
        student.Email = "allen@gmail.com";
        student.examinations = new List<Examination>();
        student.examinations.Add(new Examination() { ExaminationName = "Intermidiate C#", Month = 1, Year = 2024, MaxMarks = 100, SecuredMarks = 89 });
        student.examinations.Add(new Examination() { ExaminationName = "Advanced C#", Month = 1, Year = 2024, MaxMarks = 100, SecuredMarks = 95 });
        student.examinations.Add(new Examination() { ExaminationName = "Azure", Month = 1, Year = 2024, MaxMarks = 100, SecuredMarks = 90 });
        student.examinations.Add(new Examination() { ExaminationName = "Terraform", Month = 1, Year = 2024, MaxMarks = 100, SecuredMarks = 97 });

        //print
        Console.WriteLine("One to many relationship Example");
        Console.WriteLine("Roll No: " + student.RollNo);
        Console.WriteLine("Student Name: " + student.StudentName);
        Console.WriteLine("Email: " + student.Email);
        Console.WriteLine("EXAMINATION RESULTS: ");
        foreach(Examination exam in student.examinations)
        {
            Console.WriteLine("- "+ exam.ExaminationName+", "+ exam.Month + "-" + exam.Year + ", " + exam.SecuredMarks + "/" + exam.MaxMarks);
        }

        Console.ReadKey();
        //list object
        List<Product> products = new List<Product>();

        //loop to read data from user
        string choice;

        do
        {
            Console.Write("Enter Product ID: ");
            int pid = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Name: ");
            string pname = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            double unitPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter Product Date of Manufacture (yyyy-MM-dd): ");
            DateTime dom = DateTime.Parse(Console.ReadLine());

            //create a new object of product class
            Product product = new Product() { ProductId = pid, ProductName = pname, ProductPrice = unitPrice, DateOfManufacturing = dom };

            products.Add(product);

            //Ask the user to continue
            Console.WriteLine( "Product Added....\n");
            Console.WriteLine("Do you want to continue to next product? (Yes/No)");

            choice = Console.ReadLine();

        } while(choice != "No" && choice != "no" && choice != "n" && choice != "N");
        {
            Console.WriteLine("\nProducts:");

            //foreach
            foreach (Product item in products)
            {
                Console.WriteLine(item.ProductId + ", " + item.ProductName+ ", " + item.ProductPrice + ", " + item.DateOfManufacturing.ToShortTimeString());
            }
            Console.ReadLine();
        }

        //create an object of hashset
        Console.WriteLine("Hashset");
        HashSet<string> messages = new HashSet<string>()
        { "Good Morning", "How are you", "Have a good day."};

        //add
        messages.Add("Good to Hear from you");

        //Remove value from hashset
        messages.Remove("Have a good day.");

        //Remove where
        messages.RemoveWhere(m => m.EndsWith("you"));

        //  Count
        Console.WriteLine("Hashset Count: "+ messages.Count );

        foreach (string message in messages)
        {
            Console.WriteLine(message);
        }
        Console.WriteLine();

        //Create a hashTable
        Console.WriteLine("HashTable");
        Hashtable employees = new Hashtable()
        {
            { 102, "Smith"},
            { 105, "James"},
            { 103, "Allen"},
            {101, "Scott" },
            {104, "Jones" },
            {"Hello", 10.432 }
        };

        //Add element
        employees.Add(100, "Anna");

        //Remove element
        employees.Remove(103);

        //get value based on key
        if (employees[105] is string)
        {
            string value = Convert.ToString(employees[105]);
            Console.WriteLine("\n" + value );
        }

        //Foreach
        foreach (DictionaryEntry item in employees)
        {
            Console.WriteLine(item);
        }

        //create reference variable for list class & create object of list class
        List<int> myList = new List<int>() { 10, 20, 50 };

        //add new element at the end of the existing collection
        myList.Add(40);

        //Another collection
        List<int> anotherList = new List<int>() { 50, 60, 70 };

        //adding another collection to existing collection
        myList.AddRange(anotherList);

        //insert element at position 1
        myList.Insert(1, 100);

        //insert elements in position 2
        List<int> otherList = new List<int>() { 100, 200, 300 };
        myList.InsertRange(2, otherList);

        //search for 300
        int w = myList.IndexOf(300);

        Console.WriteLine("Search Index of 300 is:"+ w);

        //sort list
        myList.Sort();

        //collection for binary search can only be done if the list is presorted.
        int w2 = myList.BinarySearch(100);

        Console.WriteLine("BinarySearch in sorted list for  100 is:" + w2);

        //converting list to array
        int[] myListArray = myList.ToArray();

        //ForEach Method
        Console.WriteLine("\nForEach method");
        myList.ForEach(x => Console.WriteLine(x));

        //Exists: check if the student is failed
        bool b2 = myList.Exists(m => m < 35);

        if(b2 == true)
        {
            Console.WriteLine("Some Elements in the List  are less than 35");
        }
        else
        {
            Console.WriteLine("All elements in the list are greater than 35.");
        }


        //read elements using foreach loop
        Console.WriteLine("Using foreach loop to read value in a list");
        foreach(int item in myList)
        {
            Console.WriteLine(item);
        }

        //read elements using foreach loop
        Console.WriteLine("Using for loop to read value in a list");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }



        //create array of objects
        Employee[] employee = new Employee[]
        {
            new Employee(){EmpId = 101, EmpName = "Ken"},
            new Employee(){EmpId = 102, EmpName = "Mark"},
            new Employee(){EmpId = 103, EmpName = "Ben"},
        };
        Console.WriteLine(" Array of Objects ");

        //foreach loop for array of objects
        foreach (Employee Item in employee)
        {
            Console.WriteLine(Item.EmpId + ", " + Item.EmpName);
        }
        Console.ReadLine();
        

        //create jagged array
        int[][] d = new int[5][];
        d[0] = new int[3] { 30, 40, 50 };
        d[1] = new int[4] { 80, 70, 30, 90 };
        d[2] = new int[3] { 30, 40, 50 };
        d[3] = new int[6] { 30, 40, 50, 30, 40, 50 };
        d[4] = new int[9] { 30, 40, 50, 45, 66,88,99,33,44};

        Console.WriteLine("Jagged Arrays");

        //read jagged array
        for (int i = 0; i< 5; i++)
        {
            for(int j = 0; j < d[i].Length; j++)
            {
                Console.Write(d[i][j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Mult-Dim Arrays");

        //multi-dim array 4 x 3
        int[,] c = new int[4, 3]
        {
            {10, 20, 30 },
            {40, 50, 60 },
            {70, 80, 90 },
            {100, 110, 120 }
        };

        //read data from multi-dim array
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(c[i,j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //create an array
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        string[] b = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Thursday", "Friday" };

        //display the values in the array using for loop
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
        }

        Console.WriteLine();

        //for loop in reverse order
        Console.WriteLine();

        for (int i = b.Length-1; i >=0; i--)
        {
            Console.WriteLine(b[i]);
        }

        Console.WriteLine();



        //search for Friday in the array
        int n = Array.IndexOf(b, "Friday");
        Console.WriteLine("Index of Friday is " + n);
        Console.WriteLine();

        //search for Friday in the array
        int n2 = Array.IndexOf(b, "Friday", 5);
        Console.WriteLine("Index of second occurence of Friday is " + n2);
        Console.WriteLine();

        //display the values in the array using for each loop
        Array.Resize(ref a, 9);
        Array.Sort(a);
        foreach (int i in a)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        Array.Reverse(b);

        foreach (string i in b)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();


        int operation = 1;//1 to 4
        string result1;

        //switch expression
        result1 = operation switch
        {
            1 => "Customer",
            2 => "Employee",
            3 => "Supplier",
            4 => "Distributor",
            _ => "No Case available"
        };

        
        Console.WriteLine(result1);

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
