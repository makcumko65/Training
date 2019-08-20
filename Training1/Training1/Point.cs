namespace Training1
{
    public class Point
    {
        #region Constructors
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion
        #region Properties
        public double X { get; private set; }
        public double Y { get; private set; }
        #endregion
    }
}
