using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class UserInput
    {
        public static string Input()
        {
            while (true)
            {
                int smt;
                string input = Console.ReadLine();

                if (int.TryParse(input, out smt))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
        }








        public static string InputString()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
        }
    }
}
