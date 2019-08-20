using System;

namespace Training2
{
    public class SquareTask3 : FigureTask3
    {
        public SquareTask3(double x, double y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("We are in Square");
        }
    }
}
