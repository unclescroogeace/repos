using System;

namespace Integer_Romanization
{
    class Program
    {
        private static string Romanize(int integer)
        {
            if (integer < 1)
            {
                return string.Empty;
            }
            if (integer >= 1000)
            {
                return "M" + Romanize(integer - 1000);
            }
            else if (integer >= 900)
            {
                return "CM" + Romanize(integer - 900);
            }
            else if (integer >= 500)
            {
                return "D" + Romanize(integer - 500);
            }
            else if (integer >= 400)
            {
                return "CD" + Romanize(integer - 400);
            }
            else if (integer >= 100)
            {
                return "C" + Romanize(integer - 100);
            }
            else if (integer >= 90)
            {
                return "XC" + Romanize(integer - 90);
            }
            else if (integer >= 50)
            {
                return "L" + Romanize(integer - 50);
            }
            else if (integer >= 40)
            {
                return "XL" + Romanize(integer - 40);
            }
            else if (integer >= 10)
            {
                return "X" + Romanize(integer - 10);
            }
            else if (integer >= 9)
            {
                return "IX" + Romanize(integer - 9);
            }
            else if (integer >= 5)
            {
                return "V" + Romanize(integer - 5);
            }
            else if (integer >= 4)
            {
                return "IV" + Romanize(integer - 4);
            }
            else if (integer >= 1)
            {
                return "I" + Romanize(integer - 1);
            }
            throw new ArgumentOutOfRangeException("Something went wrong!");
        }

        static void Main(string[] args)
        {
            int integer;

            do
            {
                Console.Write("Enter number between 1 and 3999: ");
                int.TryParse(Console.ReadLine(), out integer);
            } while (integer <= 0 || integer >= 4000);
            Console.WriteLine($"{integer} in roman is: {Romanize(integer)}");
        }
    }
}
