using System;

namespace BetterDecorator
{
    /// <summary>
    /// The main class of the file
    /// </summary>
    class Program
    {
        /// <summary>
        /// Called in the command line arguments
        /// </summary>
        /// <param name="args">Called upon when running program</param>
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                //Convertibles
                string inputString = args[0];
                char decorationChar = args[1][0];
                int count = int.Parse(args[2]);

                Console.WriteLine(Decor(inputString, decorationChar, count));
            }
            else
            {
                Console.WriteLine(Decor());
            }
        }

        /// <summary>
        /// Gives special characters to string
        /// </summary>
        /// <param name="s">string to give characters</param>
        /// <param name="dec">the character used</param>
        /// <param name="count">the number of times the char is used</param>
        /// <returns></returns>
        private static string Decor(string s = "User did not specify args!", 
        char dec = '=', int count = 3)
        {
            return new string(dec, count) + "" + s 
            + "" + new string(dec, count);
        }
    }
}
