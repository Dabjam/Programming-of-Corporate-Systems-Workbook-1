using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите знак операции (+, -, *, /): ");
                string input = Console.ReadLine();

                Console.WriteLine("Введите второе число: ");
                int num2 = int.Parse(Console.ReadLine());

                int res = 0;
                bool valOper = true;

                if (input == "+")
                {
                    res = num1 + num2;
                }
                else if (input == "-")
                {
                    res = num1 - num2;
                }
                else if (input == "*")
                {
                    res = num1 * num2;
                }
                else if (input == "/")
                {
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    else
                    {
                        valOper = false;
                    }
                }
                else
                {
                    valOper = false;
                }
                if (valOper)
                {
                    Console.WriteLine($"Результат: {res}");
                    break;
                }
            }
        }
    }
}