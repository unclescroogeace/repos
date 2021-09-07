using System;

namespace Integer_Romanization
{
    class Program
    {
        /// <summary>
        /// This method converts a integer to Roman numeral
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string ToRomanNumeral(int number)
        {
            if (number < 1)
            {
                return string.Empty;
            }
            if (number >= 1000)
            {
                return "M" + ToRomanNumeral(number - 1000);
            }
            else if (number >= 900)
            {
                return "CM" + ToRomanNumeral(number - 900);
            }
            else if (number >= 500)
            {
                return "D" + ToRomanNumeral(number - 500);
            }
            else if (number >= 400)
            {
                return "CD" + ToRomanNumeral(number - 400);
            }
            else if (number >= 100)
            {
                return "C" + ToRomanNumeral(number - 100);
            }
            else if (number >= 90)
            {
                return "XC" + ToRomanNumeral(number - 90);
            }
            else if (number >= 50)
            {
                return "L" + ToRomanNumeral(number - 50);
            }
            else if (number >= 40)
            {
                return "XL" + ToRomanNumeral(number - 40);
            }
            else if (number >= 10)
            {
                return "X" + ToRomanNumeral(number - 10);
            }
            else if (number >= 9)
            {
                return "IX" + ToRomanNumeral(number - 9);
            }
            else if (number >= 5)
            {
                return "V" + ToRomanNumeral(number - 5);
            }
            else if (number >= 4)
            {
                return "IV" + ToRomanNumeral(number - 4);
            }
            else if (number >= 1)
            {
                return "I" + ToRomanNumeral(number - 1);
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
            Console.WriteLine($"{integer} in roman is: {ToRomanNumeral(integer)}");
        }
    }
}