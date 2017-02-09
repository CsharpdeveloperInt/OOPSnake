using System;

namespace Snake.Core
{
    internal class Point
    {
        public int X;
        public int Y;
        public char Sym;

        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.Write(Sym);
        }
    }
}
