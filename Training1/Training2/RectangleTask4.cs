using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    class RectangleTask4 : FigureTask4
    {
        public RectangleTask4(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Rectangle");
        }
    }
}
