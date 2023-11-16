
// Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки,
// и выводящую результат выполнения на экран.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[2], out int num2))
                {
                    switch (args[1])
                    {
                        case "+":
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}.");
                            break;
                        case "-":
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}.");
                            break;
                        case "*":
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}.");
                            break;
                        case "/":
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2} остаток {num1 - (num1 / num2 * num2)}.");
                            break;
                        default:
                            Console.WriteLine("Введенная Вами операция некорректна!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не числа!");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели пример некорректно!");
            }
        }
    }
}