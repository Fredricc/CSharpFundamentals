
using Categories;

internal class Program
    {
    static void Main(string[] args)
    {
        //Create structure instance
        Category category = new Category();


        //Initialize fields through properties
        category.CategoryId = 20;
        category.CategoryName = "General";

        //access methods
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
