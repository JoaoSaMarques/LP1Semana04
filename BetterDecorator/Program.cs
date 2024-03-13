using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decor("Hello, World!", '*'));
            Console.WriteLine(Decor("Hello, World!", '.'));
        }

        private static string Decor(string s, char dec)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
    }
}
