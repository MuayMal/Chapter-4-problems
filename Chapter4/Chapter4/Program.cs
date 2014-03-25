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

            int sum = 0;
            String input;
            int n;
            int reset;
            while (true)
            {


              Console.Write("Enter a number: ");  

            
            input = Console.ReadLine();
             n = Convert.ToInt32(input);

                sum = sum + n;
                reset = 999;

                if (input == "999")
                {
                    Console.WriteLine("The sum is: {0}", sum - reset);
                    break;
                   
                }
                
                
                Console.WriteLine();
            }
        }
    }
}
