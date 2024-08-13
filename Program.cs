namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;
            for (; i <= 10; i++)
            {
                for (; j <= i; j++)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
