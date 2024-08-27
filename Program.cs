namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 1;
            
            Console.WriteLine("Japan");
            Console.WriteLine("Sweden");
            Console.WriteLine("Kenya");
            myLabel:
            Console.WriteLine("France");
            Console.WriteLine("Ghana");
            Console.WriteLine("Mali");
            Console.WriteLine("Ethiopia");
            Console.WriteLine("South Africa");
            Console.WriteLine("Tanzania");
            Console.WriteLine("Uganda");
            Console.WriteLine("Dubai");
            i++;
            if(i <= 5)
            {
                goto myLabel;
            }

            Console.WriteLine("Texas");
            Console.WriteLine("Turkey");

            
            Console.ReadLine();
        }
    }
}
