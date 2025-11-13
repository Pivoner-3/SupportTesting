namespace SupportTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите два целых числа: ");
            int a = int.Parse(Console.ReadLine());
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Неверный тип данных. Введите целое число.");
                }
                break;
            }
            int b = int.Parse(Console.ReadLine());
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Неверный тип данных. Введите целое число.");
                }
                break;
            }
            Console.WriteLine($"Результат сложения: {Addition(a, b)}");
            Console.WriteLine($"Результат вычитания: {Subtraction(a, b)}");
            Console.WriteLine($"Результат сложения: {Multiplication(a, b)}");
            Console.WriteLine($"Результат вычитания: {Division(a, b)}");
        }
        static public int Addition(int first, int last)
        {
            while (true)
            {
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first + last;
        }
        static public int Subtraction(int first, int last)
        {
            while (true)
            {
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first - last;
        }
        static public int Multiplication(int first, int last)
        {
            while (true)
            {
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first * last;
        }
        static public int Division(int first, int last)
        {
            while (true)
            {
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first / last;
        }
    }
}
