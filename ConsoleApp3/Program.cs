using System;
using System.Linq;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[8, 8];
            Random ran = new Random();


            int[] arr = new int[10];
            Random r = new Random();
            int V = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
                V = arr[0] * arr[1];
            }

            int min = arr.Min();
            int max = arr.Max();

            int min_result = Array.FindAll(arr, delegate (int i) { return i == min; }).Count();
            int max_result = Array.FindAll(arr, delegate (int i) { return i == max; }).Count();

            Console.WriteLine("Задание на одномерный массив:");

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < arr.Length; i++)
                Console.Write(" " + arr[i]);

            Console.WriteLine("");
            Console.WriteLine("Массив где четные позиции в первой половине:");

            for (int i = 0; i < arr.Length; i++)
                if (i % 2 == 0)
                    Console.Write(" " + arr[i]);

            for (int i = 0; i < arr.Length; i++)
                if (i % 2 != 0)
                    Console.Write(" " + arr[i]);

            Console.WriteLine("\nМинимальный элемент в массиве: {0}", min, min_result);
            Console.WriteLine("Максимальный элемент в массиве: {0}", max, max_result);
            Console.WriteLine("Произведение элементов исходного массива между первым и вторым элементами:{0}*{1}={2}",arr[0],arr[1], V);

            Console.WriteLine("\nЗадание на двумерный массив:");
            for (int i = 0; i < 8; i++)
            {
                int sum = 0;
                bool Neg = false;

                for (int j = 0; j < 8; j++)
                {
                    Arr[i, j] = ran.Next(-3, 15);
                    Console.Write("{0}\t", Arr[i, j]);
                    int value = Arr[i, j];

                    if (value < 0)
                        Neg = true;
                    sum += value;
                }

                if (Neg)
                    Console.WriteLine("\n Строка {0} имеет отрицательные элементы. Сумма элементов = {1}", i + 1, sum);
                else
                    Console.WriteLine("\n Строка {0} не имеет отрицательные элементы", i + 1);
            }
            Console.ReadLine();
        }
    }
}