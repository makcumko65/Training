using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    class RectangleTask2 : FigureTask2
    {
        public RectangleTask2(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Rectangle");
        }
    }
}
