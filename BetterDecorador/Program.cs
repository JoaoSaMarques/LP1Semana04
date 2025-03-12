using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s, char dec, int count)
        {
            return new string(dec, count) + " " + s + " " + new string(dec, count);
        }
    }
}
