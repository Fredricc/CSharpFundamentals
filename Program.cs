
using Categories;

internal class Program
    {
    static void Main(string[] args)
    {
        User <int> user1 = new User<int>();
        User <bool> user2 = new User<bool>();
        user1.RegistrationStatus = 100;
        user2.RegistrationStatus = false;
        //Create structure instance
        Category category = new Category(30, "Senior");


        //Initialize fields through properties
        //category.CategoryId = 20;
        //category.CategoryName = "General";

        //access methods
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
