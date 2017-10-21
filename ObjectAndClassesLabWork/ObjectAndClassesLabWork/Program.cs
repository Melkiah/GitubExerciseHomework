using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndClassesLabWork
{
    class Student
    {
        public string Name;
        public int age;
        public int id;

        public Student(string name, int age, int id)
        {
            this.Name = name;
            this.age = age;
            this.id = id;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }

        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Point p = ReadPoint();
                points.Add(p);
            }

            double minDistance = double.MaxValue;

            foreach (var p1 in points)
            {
                foreach(var p2 in points)
                {
                    if(p1 != p2)
                    {
                        double dist = CalculateDistance(p1, p2);
                        if (dist < minDistance)
                        {
                            minDistance = dist;
                        }
                    }
                }
            }

            Console.WriteLine(minDistance);

        }

        private static Point ReadPoint()
        {
            Point p1 = new Point();
            string[] p1Values = Console.ReadLine().Split();
            p1.X = int.Parse(p1Values[0]);
            p1.Y = int.Parse(p1Values[1]);
            return p1;
        }
    }
}
