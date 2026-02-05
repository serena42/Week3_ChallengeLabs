using System;

namespace Week3_ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===MENU===");
                Console.WriteLine("1. Check Palindrome");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Find Two Numbers Adding to Target");
                Console.WriteLine("4. Remove AB and CD from String Iteratively");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        new Palindrome().Run();
                        break;

                    case 2:
                        new SumOfDigits().Run();
                        break;

                    case 3:
                        new ArrayAddToTarget().Run();
                        break;

                    case 4:
                        new RemoveAB_CD().Run();
                        break;

                    case 5:
                        Console.WriteLine("\nExiting...");
                        return;

                    default:
                        Console.WriteLine("Please choose a number from 1–5.\n");
                        break;
                }
            }
        }
    }
}