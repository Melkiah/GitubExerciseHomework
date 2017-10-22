using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Circle
    {
        public Point Point { get; set; }
        public int Radius { get; set; }

        public Circle(Point point, int radius)
        {
            this.Point = point;
            this.Radius = radius;
        }
    }

    class CirclesIntersection
    {


        static void Main(string[] args)
        {
            Circle firstCircle = ReadCirce();
            Circle secondCircle = ReadCirce();

            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        private static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            double dist = CalculateCircleDist(firstCircle, secondCircle);
            double sumRadiuses = firstCircle.Radius + secondCircle.Radius;
            return dist <= sumRadiuses;
        }

        private static double CalculateCircleDist(Circle firstCircle, Circle secondCircle)
        {
            double deltaX = firstCircle.Point.X - secondCircle.Point.X;
            double deltaY = firstCircle.Point.Y - secondCircle.Point.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        private static Circle ReadCirce()
        {
            string[] firstCircle = Console.ReadLine().Split().ToArray();
            Point center = new Point(int.Parse(firstCircle[0]), int.Parse(firstCircle[1]));
            Circle C = new Circle(center, int.Parse(firstCircle[2]));
            return C;
        }
    }
}