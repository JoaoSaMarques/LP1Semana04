using System;

namespace Special
{
    public class Program
    {
        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + GetSpecial(n - 2) + GetSpecial(n - 3);
        }
        
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }
    }
}
