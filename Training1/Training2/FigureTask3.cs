using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    public class FigureTask3
    {
        public double X { get; }
        public double Y { get; }
        public FigureTask3(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("We are in Figure");
        }
    }
}
