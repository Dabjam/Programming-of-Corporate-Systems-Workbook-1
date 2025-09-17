using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double res = 0; 
                float digit;

                Console.WriteLine("Введите первое число: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите знак операции (+, -, *, /, sqrt, %): ");
                string input = Console.ReadLine();
                if (input == "sqrt")
                {
                    if (num1 < 0)
                    {
                        Console.WriteLine("Ошибка: Корень из отрицательного числа невозможен");
                        continue;
                    }
                    digit = (float)num1;
                    res = Math.Pow(digit, 0.5);
                    Console.WriteLine($"Результат: {res:F2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите второе число: ");
                    int num2 = int.Parse(Console.ReadLine());

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
                            Console.WriteLine("Делить на ноль нельзя!");
                            valOper = false;
                        }
                    }
                    else if (input == "%")
                    {
                        res = num1 % num2;
                    }
                    else
                    {
                        valOper = false;
                        Console.WriteLine("Ошибка: Некорректная операция.");
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
}