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
            GetDiceSides("first");
            GetDiceSides("second");
            
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
