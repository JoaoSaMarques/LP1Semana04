using System;

namespace BetterDecorator
{
    class Program
    {
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
        }

        //Counts int
        private static string Decor(string s, char dec, int count)
        {
            return new string(dec, count) + "" + s 
            + "" + new string(dec, count);
        }
    }
}
