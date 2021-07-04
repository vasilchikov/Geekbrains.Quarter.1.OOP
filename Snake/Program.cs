using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizonalLine upLine = new HorizonalLine(0, 78, 0, '+');
            HorizonalLine downLine = new HorizonalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadKey();
        }
    }
}
