namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You need to create a two-dimensional array 5 x 5. 
             * Next, write a function that will fill it with random numbers from 30 to 60.
             * 
             * Create two more functions that find the maximum and minimum elements of this two-dimensional array.
             * Clue: use code like this to generate numbers
                //Create an object to generate numbers
                Random rnd = new Random();
 
                //Get a random number (between 0 and 10)
                int value = rnd.Next(0, 10);*/

            var twoDimensionalArray = new int[5, 5];

            FillTwoDimensionalArray(twoDimensionalArray);
            PrintArray(twoDimensionalArray);
            Console.WriteLine();
            FindMaxElementInArray(twoDimensionalArray);
            Console.WriteLine();
            FindMinElementInArray(twoDimensionalArray);
        }

        static void FillTwoDimensionalArray(int[,] array)
        {
            Random rnd = new Random();
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                }
            }
        }

        static void FindMaxElementInArray(int[,] array)
        {
            int maxElement = array[0, 0];
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                    //maxElement = maxElement < array[i, j] ? array[i, j] : maxElement;
                }
            }
            Console.WriteLine($"Maximum element is {maxElement}");
        }
        static void FindMinElementInArray(int[,] array)
        {
            int minElement = array[0, 0];
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                    }
                    //minElement = minElement > array[i, j] ? array[i, j] : maxElement;
                }
            }
            Console.WriteLine($"Minimal element is {minElement}");

        }

        static void PrintArray(int[,] array)
        {
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}