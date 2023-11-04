using System;
using System.Collections.Generic;

namespace IsPangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "The quick brown fox jumps over the lazy dog";
            
            IsPangram(message);

            Console.ReadKey();
        }
        public static bool IsPangram(string str)
        {
            var letters = new List<string>() {"a", "b", "c"};
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str.CompareTo(letters));
            }
            return true;
        }
    }
}

/*
 * A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.*/