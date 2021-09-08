using System;

namespace SortingAlgorithms
{
    class Program
    {
        static int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static int[] selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int jMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[jMin])
                    {
                        jMin = j;
                    }
                }
                if (jMin != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[jMin];
                    arr[jMin] = temp;
                }
            }

            return arr;
        }

        static int[] ArrayWithRandomNumberGenerator(int length, int minValue, int maxValue)
        {
            int[] arr = new int[length];
            Random randNum = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = randNum.Next(minValue, maxValue);
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = ArrayWithRandomNumberGenerator(20, 1, 100);
            Console.WriteLine("Before sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(Environment.NewLine + "After Bubble sorting: ");
            foreach (int num in bubbleSort(arr))
            {
                Console.Write(num + " ");
            }

            int[] arr2 = ArrayWithRandomNumberGenerator(20, 1, 100);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Before sorting: ");
            foreach (int num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(Environment.NewLine + "After Selection sorting: ");
            foreach (int num in selectionSort(arr2))
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}