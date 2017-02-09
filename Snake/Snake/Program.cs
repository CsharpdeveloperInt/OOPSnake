using System;
using Snake.Core;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var point1 = new Point
            {
                X = 8,
                Y = 10,
                Sym = '#'
            };
            point1.Draw();

            var point2 = new Point
            {
                X = 12,
                Y = 32,
                Sym = '^'
            };

            point2.Draw();
            Console.ReadLine();
        }
    }
}
