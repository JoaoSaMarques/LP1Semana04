using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program formats a given string by adding a specified character 
    // a certain number of times on both sides.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point for the program.
        /// Accepts command-line arguments: a string, a character, and an integer.
        /// </summary>
        /// <param name="args">An array of command-line arguments.</param>
        private static string Decor(string s, char dec, int count)
        {
            return new string(dec, count) + " " + s + " " + new string(dec, count);
        }

        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Please provide a string, a character, and an integer.");
                return;
            }

            string inputString = args[0];
            char inputChar = char.Parse(args[1]);
            int inputCount = int.Parse(args[2]);

            Console.WriteLine(Decor(inputString, inputChar, inputCount));
        }
    }
}
