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
        }
    }
}
