using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 4;
            int y1 = 8; 
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 2;
            int y2 = 3;
            char sym2 = '#';
            Draw(x2,y2,sym2);
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}
