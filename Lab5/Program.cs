using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            Console.WriteLine("Welcome to the Grand Circus Casino! Would you like to roll the dice? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                Console.WriteLine("Have a nice day!");
                return;
            }

            do
            {
                GetDiceSides("first");
                GetDiceSides("second");

                //Roll Dice

                Console.WriteLine("Do you want to continue rolling? (y/n)");

                string input2 = Console.ReadLine();

                if (input2.ToLower() == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    run = false;
                }

            } while (run);
            
            
        }

        public static int GetDiceSides(string nth)
        {
            Console.WriteLine("How many sides does the {0} die have?", nth);
            int sides = GetPositiveInt();
            return sides;

        }
        //Validates that input is an integer
        public static int GetValidInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input.");
            }

            return input;
        }
        //Validates that integer is within a given range
        public static int GetPositiveInt()
        {
            int input = GetValidInput();
            while (input < 1)
            {
                Console.WriteLine("Please enter a positive integer.");
                input = GetValidInput();
            }
            return input;
        }
    }
}
