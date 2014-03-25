using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            while (true)
            {

                Console.Write("Enter your hourly rate: ");

                String input = Console.ReadLine();

                n = Convert.ToDouble(input);

                if (n < 5.65 || n > 49.99)
                {
                    break;
                }
                
            }
        }
    }
}
