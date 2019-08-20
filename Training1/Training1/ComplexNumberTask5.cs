namespace Training1
{
    using System;
    public class ComplexNumberTask5
    {
        #region Fields
        private double r, i;
        #endregion
        #region Constructors
        public ComplexNumberTask5(double r, double i)
        {
            this.r = r;
            this.i = i;
        }
        #endregion
        #region Operators and Methods
        public static ComplexNumberTask5 operator *(ComplexNumberTask5 a, ComplexNumberTask5 b)
        {
            ComplexNumberTask5 res = new ComplexNumberTask5((a.r * b.r) - (a.i * b.i), (a.r * b.i) + (a.i * b.r));
            return res;
        }

        public static ComplexNumberTask5 operator /(ComplexNumberTask5 a, ComplexNumberTask5 b)
        {
            ComplexNumberTask5 res = new ComplexNumberTask5(((a.r * b.r) + (a.i * b.i)) / ((b.r * b.r) + (b.i * b.i)), ((a.i * b.r) - (a.r * b.i)) / ((b.r * b.r) + (b.i * b.i)));
            return res;
        }
        public void PrintLine()
        {
            Console.WriteLine("{0} + {1}i", this.r, this.i);
        }
        #endregion
    }
}
