using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            numList.Add(4);
            numList.Add(3);
            numList.Add(7);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            numList.RemoveAt(2);
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(3,11,'#');
            List<Point> points = new List<Point> {p1, p2};
            foreach (Point point in points)
            {
                Console.WriteLine(point.x);
                Console.WriteLine(point.y);
                Console.WriteLine(point.sym);
            }
        }

        public static void Func1(int value)
        {

        }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int x)
        {
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)
        {
            p = new Point();
        }
	}
}
