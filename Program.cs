namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            square1.Add(4, 4); //calls ChildClass1.Add

            Rectangle rectangle1 = new Rectangle();
            square1.Add(40, 100); //calls ChildClass2.Add



            int i = 1;
            
            Console.WriteLine("Japan");
            Console.WriteLine("Sweden");
            Console.WriteLine("Kenya");
            myLabel:
            Console.WriteLine("France");
            Console.WriteLine("Ghana");
            Console.WriteLine("Dubai");
            Console.WriteLine("Mali");
            Console.WriteLine("Ethiopia");
            Console.WriteLine("South Africa");
            Console.WriteLine("Tanzania");
            Console.WriteLine("Uganda");
            Console.WriteLine("Senegal");
            i++;
            if(i <= 5)
            {
                goto myLabel;
            }

            Console.WriteLine("Germany");
            Console.WriteLine("Turkey");

            
            Console.ReadLine();
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
    }
}
