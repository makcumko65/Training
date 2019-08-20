using System;

namespace Training1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#############################  TASK1  ########################//
            Console.WriteLine("#############################  TASK1  ########################");
            Point a = new Point(-3, 1);
            Point c = new Point(5, -4);

            RectangleTask1 rectangle = new RectangleTask1(a, c);
            Console.WriteLine($"P = {rectangle.Perimetr()}");
            Console.WriteLine($"S = {rectangle.Square()}");
            
            //#############################  TASK2  ########################//
            Console.WriteLine("#############################  TASK2  ########################");
            RectangleTask2 rectangle1 = new RectangleTask2(a, c);
            Console.WriteLine($"P = {rectangle1.Perimetr}");
            Console.WriteLine($"S = {rectangle1.Square}");
            
            //#############################  TASK3  ########################//
            Console.WriteLine("#############################  TASK3  ########################");
            CircleTask3 circle = new CircleTask3();
            Console.WriteLine($"S = {circle.Square(7)}");
            Console.WriteLine($"L = {circle.LengthOfCircle(7)}");

            //#############################  TASK4  ########################//
            Console.WriteLine("#############################  TASK4  ########################");
            Console.WriteLine($"P = {StaticRectangleTask4.Perimetr(a,c)}");
            Console.WriteLine($"S = {StaticRectangleTask4.Square(a,c)}");
            Console.WriteLine($"S = {StaticCircleTask4.Square(7)}");
            Console.WriteLine($"L = {StaticCircleTask4.LengthOfCircle(7)}");

            //#############################  TASK5  ########################//
            Console.WriteLine("#############################  TASK5  ########################");
            ComplexNumberTask5 complexNumber1 = new ComplexNumberTask5(7, -4);
            ComplexNumberTask5 complexNumber2 = new ComplexNumberTask5(3, 2);
            var result = complexNumber1 * complexNumber2;
            result.PrintLine();
            var result2 = complexNumber1 / complexNumber2;
            result2.PrintLine();

            Console.Read();
        }
    }
}
