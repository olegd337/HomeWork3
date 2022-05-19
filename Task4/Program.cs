namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
// TODO
            /*
            1. Реализация метода, умножающего число на 5. Число является входным параметром метода.  
            Метод получает значение числа, умножает его на 5 и возвращает благодаря модификатору ref.  
            То есть, метод увеличивает самый аргумент в 5 раз.
            2. Даны координаты вершин треугольника и радиус круга. Определить площади фигур. (Использовать Out )
            3.  Дан целочисленный массив. Найти сумму и произведение всех элементов массива, которые стоят на четных местах. Массив передавать как params
            */
            Console.WriteLine("Enter number:");
            var inputNumber = int.Parse(Console.ReadLine());
            MultiplySomeNumber(ref inputNumber);
            Console.WriteLine(inputNumber);

            
        }

        static void MultiplySomeNumber(ref int inputNumber)
        {
            inputNumber *= 5;
        }

        static void FindCircleSquare(double circleRadius, out double  circleSquare)
        {
            circleSquare = 3.14 * circleRadius;
        }
    }
}