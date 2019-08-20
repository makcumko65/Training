using System;
using System.Collections.Generic;
using System.Text;

namespace Training2
{
    public class SquareTask2 : FigureTask2
    {
        public SquareTask2(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Square");
        }
    }
}
