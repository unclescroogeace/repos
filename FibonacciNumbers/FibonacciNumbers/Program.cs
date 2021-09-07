using System;

namespace FibonacciNumbers
{
    class Program
    {
        private static void FibonacciRecoursive(int a, int b, int num)
        {
            Console.Write(a + " ");
            if (num > 1)
            {
                FibonacciRecoursive(b, a + b, --num);
            }
        }

        private static int[] FibonacciSeries(int num)
        {
            int[] arr;
            if (num < 2)
            {
                arr = new int[2];
            }
            else
            {
                arr = new int[num];
            }
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < num; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr;
        }

        private static void PrintFibonacciSeries(int[] arr, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter N: ");
                int.TryParse(Console.ReadLine(), out num);
            } while (num < 1);
            FibonacciRecoursive(0, 1, num);
            Console.WriteLine();
            PrintFibonacciSeries(FibonacciSeries(num), num);
        }
    }
}