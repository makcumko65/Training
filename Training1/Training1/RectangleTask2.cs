namespace Training1
{
    public class RectangleTask2
    {
        #region Fields
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        #endregion
        #region Constructors
        public RectangleTask2(Point a, Point c)
        {
            this.a = new Point(a.X, a.Y);
            this.c = new Point(c.X, c.Y);
            this.d = new Point(a.X, c.Y);
            this.b = new Point(c.X, a.Y);
        }
        #endregion
        #region Properties
        public double Perimetr
        {
            get
            {
                return 2 * (this.b.X - this.a.X + (this.a.Y - this.d.Y));
            }
        }

        public double Square
        {
            get
            {
                return (this.b.X - this.a.X) * (this.a.Y - this.d.Y);
            }
        }
        #endregion
    }
}
