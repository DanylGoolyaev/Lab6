using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._3
{
    class Round : Figure
    {
        double r;
        public Round(double radius)
        {
            r = radius;
        }
        public override double S { get; set; }

        public override double Area()
        {
            S = 3.14 * r * r;
            Console.WriteLine(S);
            return S;
        }
    }
}
