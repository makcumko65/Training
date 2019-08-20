using System;
using System.Collections.Generic;

namespace Training2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////########################## TASK1 #############################
            Console.WriteLine("########################## TASK1 #############################");
            FigureTask1 square = new SquareTask1();
            FigureTask1 rectangle = new RectangleTask1();
            square.Draw();
            rectangle.Draw();
            ////########################## TASK2 #############################
            Console.WriteLine("########################## TASK2 #############################");
            FigureTask2 square2 = new SquareTask2(0.1, 0.3);
            RectangleTask2 rectangle2 = new RectangleTask2(2, 3.4);
            ////########################## TASK3 #############################
            Console.WriteLine("########################## TASK3 #############################");
            List<FigureTask3> figures = new List<FigureTask3>()
            {
                new FigureTask3(2, 1),
                new SquareTask3(0.1, 0.3),
                new RectangleTask3(2, 3.4)
            };
            foreach(FigureTask3 figure in figures)
            {
                figure.Draw();
            }
            ////########################## TASK4 #############################
            Console.WriteLine("########################## TASK4 #############################");
            FigureTask4 square4 = new SquareTask4(0.1, 0.3);
            RectangleTask4 rectangle4 = new RectangleTask4(2, 3.4);
            FigureTask4 figure4 = new FigureTask4(2, 1);
            DrawAll(square4, rectangle4, figure4);

            Console.Read();
        }
        public static void DrawAll(params IDrawable[] drawables)
        {
            foreach(IDrawable item in drawables)
            {
                item.Draw();
            }
        }
    }
}
