using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowels.cs
{
    class Program
    {
        static void Main(string[] args)
        {
   
            
            while (true)
            {

                Console.Write("Enter a vowel: ");

                String input = Console.ReadLine().ToLower();

                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("OK");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Error not a vowel!!!");
                    Console.WriteLine();

                }

                if (input == "!")
                {
                    break;
                }

            }
        }
    }
}
