using System;

namespace Power2Method
{
    class Program
    {
        //Exe1 + Exe 4.2
        private static void Power2Method5()
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
                Powers2UntilN(5);
            }
            
        }
        //Exe 4.1
        private static void Powers2UntilN(int n)
        {
            for(int i = 0; i <= n; i = i++)
            {
                int powerof2 = (int)Math.Pow(2, i);
                Console.WriteLine(powerof2);
            }
            
        }
        //Main
        static void Main(string[] args)
        {
            Power2Method5();
            Power2Method5();
            Powers2UntilN(5);
            Powers2UntilN(10);
        }
    }
}
