namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1. Реализация метода, умножающего число на 5. Число является входным параметром метода.  
               Метод получает значение числа, умножает его на 5 и возвращает благодаря модификатору ref.  
               То есть, метод увеличивает самый аргумент в 5 раз.
            2. Даны координаты вершин треугольника и радиус круга. Определить площади фигур. (Использовать Out )
            3. Дан целочисленный массив. Найти сумму и произведение всех элементов массива, которые стоят на четных местах. 
            Массив передавать как params
            */

            //Реализация метода, умножающего число на 5
            Console.WriteLine("Enter number:");
            var input = int.Parse(Console.ReadLine());
            MultiplySomeNumber(ref input);
            Console.WriteLine($"Multiply to 5 will be: {input}");
            Console.WriteLine("=====================================================");

            //Определить площади фигур
            Console.WriteLine("Enter circle square:");
            var inputRadius = double.Parse(Console.ReadLine());
            FindCircleSquare(inputRadius, out var square);
            Console.WriteLine($"Square of circle will be: {square}");

            Console.WriteLine("=======================================================");
            Console.WriteLine("Calculate triangle square:");
            var triangleDots = new int[3, 2];
            Console.WriteLine("Enter X1");
            triangleDots[0, 0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1");
            triangleDots[0, 1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2");
            triangleDots[1, 0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2");
            triangleDots[1, 1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X3");
            triangleDots[2, 0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y3");
            triangleDots[2, 1] = int.Parse(Console.ReadLine());

            FindTriangleSquare(triangleDots, out double squareTriangle);
            Console.WriteLine($"Square of triangle will be - {squareTriangle}");

        }

        static void MultiplySomeNumber(ref int inputNumber)
        {
            inputNumber *= 5;
        }

        static void FindCircleSquare(double circleRadius, out double circleSquare)
        {
            circleSquare = 3.14 * circleRadius * circleRadius;
        }
        static void FindTriangleSquare(int[,] triangleDots, out double triangleSquare)
        {
            triangleSquare = 0.5 * ((triangleDots[0, 0] - triangleDots[2, 0]) * (triangleDots[1, 1] - triangleDots[2, 1])
                - (triangleDots[1, 0] - triangleDots[2, 0]) * (triangleDots[0, 1] - triangleDots[2, 1]));
        }

        static int ArrayOddElementsSum(int[] array)
        {
            var arrayOddElementsSum = array[0];
            for (int i = 0; i < array.Length; i += 2)
            {
                arrayOddElementsSum += array[i];
            }
            return arrayOddElementsSum;
        }
        static int ArrayOddElementsMultiply(int[] array)
        {
            var arrayOddElementsSum = array[0];
            for (int i = 0; i < array.Length; i += 2)
            {
                arrayOddElementsSum += array[i];
            }
            return arrayOddElementsSum;
        }


    }
}