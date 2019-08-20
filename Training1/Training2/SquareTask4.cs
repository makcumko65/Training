using System;

namespace Training2
{
    public class SquareTask4 : FigureTask4
    {
        public SquareTask4(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Square");
        }
    }
}
