﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> pList = new List<Point>();

        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }
    }
}
