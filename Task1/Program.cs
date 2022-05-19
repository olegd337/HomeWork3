namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputRangeOfNumbers();
        }

        static void OutputRangeOfNumbers()
        {
            for (int i = 2; i <= 100; i++)
            {
                Console.Write($"{i}; ");
            }
        }
    }
}