using System;
using System.Collections.Generic;


namespace Learn
{
    internal static class Program
    {
        static void Main()
        {
            int Limit1 = 1;
            int Limit2 = 100;
            Console.WriteLine("Enter a number between {0} and {1} : ", Limit1, Limit2);
            
            int userInt;

            bool game = true; 
            while (game)
            {
                if (!int.TryParse(Console.ReadLine(), out userInt))
                {
                    Console.WriteLine("You did not enter a number, try again :");
                }
                else
                {
                    if (userInt > Limit2)
                    {
                        Console.WriteLine("You have entered {0} which is greater than {1} which is the maximum try again with a lower num :", userInt, Limit2);
                    }
                    else if (userInt < Limit1)
                    {
                        Console.WriteLine("You have entered {0} which is lower than {1} which is the minimum try again with a higher num : ", userInt, Limit1);
                    }
                    else
                    {
                        Console.WriteLine("You have entered {0} which is between {1} and {2}", userInt, Limit1, Limit2);
                        game = false;
                    }
                }
            }
            Environment.Exit(0);
        }
    }
}
