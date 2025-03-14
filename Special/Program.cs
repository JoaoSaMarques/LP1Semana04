﻿using System;

namespace Special
{
    public class Program
    {
        /// <summary>
        /// Recursively calculates the n-th number in the special sequence.
        /// </summary>
        /// <param name="n">The index of the number in the special sequence.</param>
        /// <returns>The n-th number in the special sequence.</returns>
        private static int GetSpecial(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + GetSpecial(n - 2) + GetSpecial(n - 3);
        }

        /// <summary>
        /// The main entry point for the program.
        /// </summary>
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }
    }
}
