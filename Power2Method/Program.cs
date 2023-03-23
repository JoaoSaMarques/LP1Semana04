using System;

namespace Power2Method
{
    class Program
    {
        //Exe1 + Exe 4.2
        /// <summary>
        /// i shifts 5 times.
        /// </summary>
        private static void Power2Method5()
        {
            for(int i = 1; i <= (1 << 5); i = i << 1)
            {
                Powers2UntilN(5);
            }
            
        }
        //Exe 4.1
        /// <summary>
        /// Write int
        /// </summary>
        /// <param name="n"></param>
        private static void Powers2UntilN(int n)
        {
            for(int i = 0; i <= n; i = i++)
            {
                int powerof2 = (int)Math.Pow(2, i);
                Console.WriteLine(powerof2);
            }
            
        }
        //Main
        /// <summary>
        /// call both methods.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Power2Method5();
            Power2Method5();
            Powers2UntilN(5);
            Powers2UntilN(10);
        }
    }
}
