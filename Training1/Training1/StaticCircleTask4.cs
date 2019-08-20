namespace Training1
{
    using System;
    public static class StaticCircleTask4
    {
        #region Fields
        public const double PI = 3.14;
        #endregion

        #region Methods
        public static double LengthOfCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must be > 0");
            }
            return 2 * PI * radius;
        }
        public static double Square(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Radius must be > 0");
            }
            return PI * radius * radius;
        }
        #endregion
    }
}
