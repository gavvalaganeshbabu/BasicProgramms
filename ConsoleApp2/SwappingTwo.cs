using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class SwappingTwo
    {
        public void SwapTwo() {
            Console.WriteLine("Enter Two Numbers :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            c = a; a = b; b = c;
            Console.WriteLine("After Swapped :");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
