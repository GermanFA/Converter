﻿using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double rubToUsd = 0.013, 
            rubToEuro = 0.011,
            usdToRub = 74.61,
            usdToEuro = 0.83,
            euroToUsd = 1.2,
            euroToRub = 89.65;
            double rub = 1000,
            usd = 80,
            euro = 50;
            int userInput;
            double swap;

            Console.WriteLine($"Ваш баланс:{rub} рублей,{usd} долларов,{euro} евро.");
            Console.WriteLine("Список операций: 1. обмен рублей на доллары 2. обмен рублей на евро 3. обмен долларов на рубли " +
            "4. обмен долларов на евро 5. обмен евро на доллары 6. обмен евро на рубли 7. завершить операцию");
            Console.WriteLine("Введите число:");
            userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != 7) 
            {
                switch (userInput) 
                {
                    case 1:
                        Console.WriteLine("Сколько вы хотите поменять рублей:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (rub - swap < 0) 
                            {
                            rub = rub + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                            }
                            else
                            {
                            usd = usd + (swap * rubToUsd);
                            rub = rub - swap;
                            }
                        
                        break;

                     case 2:
                        Console.WriteLine("Сколько вы хотите поменять рублей:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (rub - swap < 0)
                        {
                            rub = rub + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                        }
                        else
                        {
                            euro = euro + (swap * rubToEuro);
                            rub = rub - swap;
                        }

                        break;

                    case 3:
                        Console.WriteLine("Сколько вы хотите поменять долларов:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (usd - swap < 0)
                        {
                            usd = usd + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                        }
                        else
                        {
                            rub = rub + (swap * usdToRub);
                            usd = usd - swap;
                        }

                        break;

                    case 4:
                        Console.WriteLine("Сколько вы хотите поменять долларов:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (usd - swap < 0)
                        {
                            usd = usd + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                        }
                        else
                        {
                            euro = euro + (swap * usdToEuro);
                            usd = usd - swap;
                        }

                        break;

                    case 5:
                        Console.WriteLine("Сколько вы хотите поменять евро:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (euro - swap < 0)
                        {
                            euro = euro + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                        }
                        else
                        {
                            usd = usd + (swap * euroToUsd);
                            euro = euro - swap;
                        }

                        break;

                    case 6:
                        Console.WriteLine("Сколько вы хотите поменять евро:");
                        swap = Convert.ToDouble(Console.ReadLine());
                        if (euro - swap < 0)
                        {
                            euro = euro + swap;
                            Console.WriteLine("Операция невозможна, недостаточно средств");
                        }
                        else
                        {
                            rub = rub + (swap * euroToRub);
                            euro = euro - swap;
                        }

                        break;

                }

                Console.WriteLine($"Ваш баланс:{rub} рублей,{usd} долларов,{euro} евро. Введите операцию:");
                userInput = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
