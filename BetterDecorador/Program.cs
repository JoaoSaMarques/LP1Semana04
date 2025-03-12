using System;

namespace BetterDecorador
{
    public class Program
    {
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
        }
    }
}
