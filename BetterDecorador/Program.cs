﻿using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program formats a given string by adding a specified character 
    /// a certain number of times on both sides.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Formats the input string by surrounding it with a specified character repeated a given number of times.
        /// </summary>
        /// <param name="s">The string to be formatted.</param>
        /// <param name="dec">The character to surround the string.</param>
        /// <param name="count">The number of times the character should be repeated on each side.</param>
        /// <returns>A formatted string with the character surrounding the input string.</returns>
        private static string Decor(string s, char dec, int count)
        {
            return new string(dec, count) + " " + s + " " + new string(dec, count);
        }

        /// <summary>
        /// Formats a default message when no command-line arguments are provided.
        /// </summary>
        /// <returns>A formatted string with a default message.</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }

        /// <summary>
        /// The main entry point for the program.
        /// Accepts command-line arguments: a string, a character, and an integer.
        /// </summary>
        /// <param name="args">An array of command-line arguments.</param>
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(Decor());
                return;
            }

            string inputString = args[0];
            char inputChar = char.Parse(args[1]);
            int inputCount = int.Parse(args[2]);

            Console.WriteLine(Decor(inputString, inputChar, inputCount));
        }
    }
}