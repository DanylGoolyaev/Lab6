using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._3
{
    class Square : Figure
    {
        double a;

        public Square(double side)
        {
            a = side;
        }

        public override double S { get; set; }

        public override double Area()
        {
            S = a * a;
            Console.WriteLine(S);
            return S;
        }
    }
}
