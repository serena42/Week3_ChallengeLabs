using System;
using System.Text;

namespace Week3_ChallengeLabs
{
    internal class RemoveAB_CD
    {
        // Generate a random ABCDEF string
        public static string GenerateRandomString()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            char[] letters = "ABCDEF".ToCharArray();
            int length = rnd.Next(5, 21);

            for (int i = 0; i < length; i++)
            {
                sb.Append(letters[rnd.Next(letters.Length)]);
            }

            return sb.ToString();
        }

        // Remove all occurrences of AB and CD from a string
        public static string RemoveABCD(string input)
        {
            StringBuilder cleaned = new StringBuilder();
            int i = 0;

            while (i < input.Length)
            {
                if (i < input.Length - 1 &&
                    ((input[i] == 'A' && input[i + 1] == 'B') ||
                     (input[i] == 'C' && input[i + 1] == 'D')))
                {
                    i += 2; // Skip "AB" or "CD"
                }
                else
                {
                    cleaned.Append(input[i]);
                    i++;
                }
            }

            return cleaned.ToString();
        }
        // Runner for the menu
        public void Run()
        {
            string randomString = GenerateRandomString();
            Console.WriteLine($"\nGenerated String: {randomString}");
            string result = RemoveABCD(randomString);
            Console.WriteLine($"String after removing AB and CD: {result}\n");
        }
    }
}