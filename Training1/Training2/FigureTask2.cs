using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    abstract public class FigureTask2
    {
        public double X { get; }
        public double Y { get; }
        public FigureTask2(double x, double y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw();
    }
}
