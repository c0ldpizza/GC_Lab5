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
                Console.Clear();

                int diceOne = GetDiceSides("first");
                int diceTwo = GetDiceSides("second");

                //Roll Dice


                int rollOne = RollDice(diceOne);
                int rollTwo = RollDice(diceTwo);

                Console.WriteLine("The results were {0} and {1}!\n", rollOne, rollTwo);

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
            Console.WriteLine();
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

        //rolls dice using rng
        public static int RollDice(int sides)
        {
            Random rnd = new Random();
            int result = rnd.Next(1, sides);
            return result;
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
