namespace Training1
{
    public class RectangleTask1
    {
        #region Fields
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private double p;
        private double s;
        #endregion
        #region Constructors
        public RectangleTask1(Point a, Point c)
        {
            this.a = new Point(a.X, a.Y);
            this.c = new Point(c.X, c.Y);
            this.d = new Point(a.X, c.Y);
            this.b = new Point(c.X, a.Y);
        }
        #endregion
        #region Methods
        public double Perimetr()
        {
            this.p = 2 * (this.b.X - this.a.X + (this.a.Y - this.d.Y));
            return this.p;
        }
        public double Square()
        {
            this.s = (this.b.X - this.a.X) * (this.a.Y - this.d.Y);
            return this.s;
        }
        #endregion
    }
}
