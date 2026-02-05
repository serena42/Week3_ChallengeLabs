using System;
using System.Text.RegularExpressions;

namespace Week3_ChallengeLabs
{
    internal class Palindrome
    {
        // Pure logic method
        public static bool IsPalindrome(string input)
        {
            input = Regex.Replace(input.ToLower(), "[^a-z0-9]", "");
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        // Runner for the menu
        public void Run()
        {
            Console.Write("\nEnter a string to check: ");
            string input = Console.ReadLine();

            bool result = IsPalindrome(input);

            Console.WriteLine(result
                ? $"\"{input}\" IS a palindrome.\n"
                : $"\"{input}\" is NOT a palindrome.\n");
        }
    }
}