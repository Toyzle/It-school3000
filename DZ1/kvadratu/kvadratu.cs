using System;

namespace Kvadratu 
{
    class Program;
    {
        static void Squares()
                {
                    int INum = 0;
                    Console.WriteLine("Для вычисления квадратов чисел введите целое число:");
                    string num = Console.ReadLine();
                    try
                    {
                        INum = Int16.Parse(num);
                    }
                    catch
                    {
                        Console.WriteLine("Вы ввели не целое число. Программа завершает свою работу."); return;
                    }
                    if (INum <= 1) { Console.WriteLine("Введенное число <= 1. Программа завершает свою работу."); return; }
                    Console.WriteLine("Квадраты целых чисел меньше " + num + ":");
                    int i = 1;
                    while (i * i < INum)
                    {
                        Console.WriteLine((i * i++).ToString());
                    }
                }