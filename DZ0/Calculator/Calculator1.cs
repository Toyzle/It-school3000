using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char symbol;
            Console.WriteLine("Writlen first number:");
            a = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Writlen second number:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Operator?");
            symbol = Convert.ToChar(Console.ReadLine());
            if (symbol == '+')
                {
                    total = a + b;
                    Console.WriteLine("Total " + a + " и " + b + " ravno " + total + ".");
                }
 
                else if (symbol == '-')
                {
                    total = a - b;
                    Console.WriteLine("Total " + a + " и " + b + " ravno " + total + ".");
                }
 
                else if (symbol == '*')
                {
                    total = a * b;
                    Console.WriteLine("Total " + a + " на " + b + " ravno " + total + ".");
                }
 
                else if (symbol == '/')
                {
                    total = a / b;
                    if(b == 0){
                        Console.WriteLine("na 0 nuziya");
                }
                    else 
                        Console.WriteLine("Delenie " + a + " на " + b + " ravno " + total + ".");
                }
                else
                {
                    Console.WriteLine("bachok potik");
                }
        }
    }
}

