namespace SupportTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод двух целых чисел.
            Console.WriteLine("Напишите два целых числа: ");
            int a = int.Parse(Console.ReadLine());
            while (true)
            {
                //Проверка на корректность введенного типа данных.
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Неверный тип данных. Введите целое число.");
                }
                break;
            }
            int b = int.Parse(Console.ReadLine());
            while (true)
            {
                //Проверка на корректность введенного типа данных.
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Неверный тип данных. Введите целое число.");
                }
                break;
            }
            //Вывод всех базовых математических операций двух введенных чисел.
            Console.WriteLine($"Результат сложения: {Addition(a, b)}");
            Console.WriteLine($"Результат вычитания: {Subtraction(a, b)}");
            Console.WriteLine($"Результат сложения: {Multiplication(a, b)}");
            Console.WriteLine($"Результат вычитания: {Division(a, b)}");
        }
        //Метод сложения.
        static public int Addition(int first, int last)
        {
            while (true)
            {
                //Проверка на корретный ввод числа.
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first + last;
        }
        //Метод вычитания.
        static public int Subtraction(int first, int last)
        {
            while (true)
            {
                //Проверка на корретный ввод числа.
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first - last;
        }
        //Метод умножения.
        static public int Multiplication(int first, int last)
        {
            while (true)
            {
                //Проверка на корретный ввод числа.
                if (first == ' ' && last == ' ')
                {
                    Console.WriteLine("Поле не должно быть пустым!");
                    continue;
                }
                break;
            }
            return first * last;
        }
        //Метод деления.
        static public int Division(int first, int last)
        {
            while (true)
            {
                //Проверка на корретный ввод числа.
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
