using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence:");
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
