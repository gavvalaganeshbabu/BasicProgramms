using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Fibbonocci
    {
        public void  FibbonicciSeries() {
            Console.WriteLine("Enter upto number");
            int f = int.Parse(Console.ReadLine());
            int a2 = 0;
            int b2 = 1;
            int c2;

            while (b2 < f)
            {
                c2 = a2 + b2;
                Console.WriteLine(c2);
                a2 = b2;
                b2 = c2;

            }
        }
    }
}
