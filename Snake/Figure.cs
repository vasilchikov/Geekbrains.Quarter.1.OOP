using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (Point points in pList)
            {
                points.Draw();
            }
        }
    }
}
