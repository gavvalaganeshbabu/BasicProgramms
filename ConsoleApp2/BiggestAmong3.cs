using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class BiggestAmong3
    {
        public void BiggestOfThree() {
            Console.WriteLine("Enter Three Numbers :");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            if (a1 > b1 && a1 > c1)
            {
                Console.WriteLine(a1 + " is bigger");
            }
            else if (b1 > a1 && b1 > c1)
            {
                Console.WriteLine(b1 + "is Bigger ");
            }
            else { Console.WriteLine(c1 + "is Bigger"); }
        }
    }
}
