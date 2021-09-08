using System;

namespace SortingAlgorithms
{
    class Program
    {
        static int[] BubbleSort(int[] arr)
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

        static int[] SelectionSort(int[] arr)
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

        static int BinarySearch(int[] arr, int t)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] < t)
                {
                    left = mid + 1;
                }
                else if (arr[mid] > t)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public static void RunBinarySearch(int[] arr, int t)
        {
            int index = BinarySearch(arr, t);
            if (index >= 0)
            {
                Console.WriteLine($"The searched element was found at at position {index + 1} with index of {index}");
            }
            else
            {
                Console.WriteLine("The searched element was not found");
            }
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
            foreach (int num in BubbleSort(arr))
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
            foreach (int num in SelectionSort(arr2))
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            int[] arr3 = new int[] { 1, 4, 7, 8, 12, 14, 16, 36, 45, 46, 48, 53, 60 };
            foreach (int num in arr3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            RunBinarySearch(arr3, 1);
        }
    }
}