namespace Training1
{
    public static class StaticRectangleTask4
    {
        #region Properties
        public static double Perimetr(Point a, Point c)
        {
            return 2 * (c.X - a.X + (a.Y - c.Y));
        }

        public static double Square(Point a, Point c)
        {
            return (c.X - a.X) * (a.Y - c.Y);
        }
        #endregion
    }
}
