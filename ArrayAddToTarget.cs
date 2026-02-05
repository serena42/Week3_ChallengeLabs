using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_ChallengeLabs
{
    internal class ArrayAddToTarget
    {

        // Method to find two numbers in an array that add up to a target sum without using dictionaries
        public ArrayAddToTarget() { }
        public static int[] FindTwoNumbers(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { nums[i], nums[j] };
                    }
                }
            }
            return new int[] { }; // Return empty array if no pair is found
        }
        public static int[] GenerateTestData(out int target)
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 15);

            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
            {
                nums[i] = rnd.Next(1, 20);
            }

            target = rnd.Next(10, 30);
            return nums;
        }
        // Runner for the menu
        public void Run()
        {
            int target;
            int[] nums = GenerateTestData(out target);

            Console.WriteLine("\nGenerated numbers: " + string.Join(", ", nums));
            Console.WriteLine("Target: " + target);

            int[] result = FindTwoNumbers(nums, target);

            if (result != null && result.Length == 2)
            {
                Console.WriteLine($"\nNumbers found: {result[0]} + {result[1]} = {target}\n");
            }
            else
            {
                Console.WriteLine("\nNo two numbers add up to the target.\n");
            }
        }
    }
}
