using System;
namespace ConsoleApplication1
{
        class Program
        {
            static void Main(string[] args)
            {
                int[] mas5 = { 1, 1, 2, 2, 2, 3, 3, 3, 3 };
                int[] res = new int[3];//в этот массив результат выведется (в данном случае должно быть 234)
 
                for (int i = 0; i < res.Length; i++)
                    res[i] = 0;//Обнуляем значения массива
 
                for (int i = 0; i < mas5.Length; i++)
                {
                    res[mas5[i] - 1]++;
                }
                for (int i = 0; i < res.Length; i++)
                {
                    Console.Write(res[i]);
                }
                Console.ReadKey();
            }
    }
}