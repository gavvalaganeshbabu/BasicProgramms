using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class EvenOdd
    {
        public void EvenOd()
        {
           
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else { Console.WriteLine("Odd"); }
        }
    }
}
