namespace Training1
{
    public class CircleTask3
    {
        #region Fields and Properties
        public const double PI = 3.14;
        public double L { get; private set; }

        public double S { get; private set; }
        #endregion
        #region Methods
        public double LengthOfCircle(double radius)
        {
            this.L = 2 * PI * radius;
            return this.L;
        }

        public double Square(double radius)
        {
            this.S = PI * radius * radius;
            return this.S;
        }
        #endregion
    }
}
