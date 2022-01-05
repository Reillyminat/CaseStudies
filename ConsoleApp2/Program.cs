using System;

namespace ConsoleApp2
{
    internal class Program
    {
        struct Point
        {
            public int x, y;
            public Point(int x, int y)
            { this.x = x; this.y = y; }
        }

        enum Difficulty
        {
            Easy = 1,
            Average = 3,
            Hard = 5
        }

        delegate double DelegateMethod(int op1, int op2, int op3, int op4);

        public static double Distance(int x1, int y1, int x2, int y2) { return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); }

        static void Main(string[] args)
        {
            Difficulty difficulty = Difficulty.Easy;

            Point point1 = new Point(2, 10);
            Point point2 = new Point(4, 5);
            Console.WriteLine("Point 1 coordinates is: x = {0}, y = {1}, Point 2 coordinates is: x = {2}, y = {3}", point1.x, point1.y, point2.x, point2.y);

            DelegateMethod delegateMethod = Distance;
            Console.WriteLine("Distance between point 1 and 2 is {0}", delegateMethod(point1.x, point1.y, point2.x, point2.y));

            var budget = 315.5m;
            Console.WriteLine("Budget type is {0}", budget.GetType());
        }
    }
}
