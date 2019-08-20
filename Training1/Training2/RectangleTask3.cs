using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    class RectangleTask3 : FigureTask3
    {
        public RectangleTask3(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Rectangle");
        }
    }
}
