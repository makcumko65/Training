using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training1.Tests
{
    [TestClass]
    public class RectangleTask1Tests
    {
        [TestMethod]
        public void Perimetr()
        {
            //arrange 
            Point a = new Point(-4, 3);
            Point b = new Point(3, -4);
            double expected = 28;
            //act
            RectangleTask1 rectangle = new RectangleTask1(a, b);
            double actual = rectangle.Perimetr();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Square()
        {
            //arrange 
            Point a = new Point(-4, 3);
            Point b = new Point(3, -4);
            double expected = 49;
            //act
            RectangleTask1 rectangle = new RectangleTask1(a, b);
            double actual = rectangle.Square();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
