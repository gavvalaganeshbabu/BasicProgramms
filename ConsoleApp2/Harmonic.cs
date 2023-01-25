using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Harmonic
    {
        public void HarmonicFind() {
            Console.WriteLine("Enter The Number :");
            int h = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i < h; i++)
            {
                sum = sum + (double)1 / i;
            }
            Console.WriteLine(sum);
        }
    }
}
