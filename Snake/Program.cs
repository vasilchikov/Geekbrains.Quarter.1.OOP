using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizonalLine horizonalLine = new HorizonalLine(0, 45, 10, '+');
            horizonalLine.Draw();
            VerticalLine verticalLine = new VerticalLine(0, 10, 45, '#');
            verticalLine.Draw();
        }
    }
}
