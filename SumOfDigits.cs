using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_ChallengeLabs
{
    internal class SumOfDigits
    {
        // Method to calculate the sum of digits in a string
        public static int CalculateSumOfDigits(string input)
        {
            int sum = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    sum += (int)char.GetNumericValue(c);
                }
            }
            return sum;
        }

        // Runner for the menu
        public void Run()
        {
            Console.Write("\nEnter a string containing digits: ");
            string input = Console.ReadLine();
            int sum = CalculateSumOfDigits(input);
            Console.WriteLine($"The sum of digits in the string is: {sum}\n");
        }
    }
}
