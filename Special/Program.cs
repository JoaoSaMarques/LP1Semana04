using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static int GetSpecial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return GetSpecial(n - 1) + 1;
            }
        }
    }
}
