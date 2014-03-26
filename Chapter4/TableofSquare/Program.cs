using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableofSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int square;
            for (int i = 1; i <= 20; i++)
            {

                


                square = i * i;

                Console.WriteLine("The number: {0} is squared into: {1}",i,square);
            }
        }
    }
}
