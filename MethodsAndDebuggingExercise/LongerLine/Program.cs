using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static double CalculateDistanceFromCentre(double x, double y)
        {
            double distance = 0.0;
            distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        static void PrintLineClosestToCentre(double x1, double y1, double x2, double y2)
        {
            double firstDistance = CalculateDistanceFromCentre(x1, y1);
            double secondDistance = CalculateDistanceFromCentre(x2, y2);

            if (firstDistance < secondDistance)
            {
                Console.Write("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
            else if (secondDistance < firstDistance)
            {
                Console.Write("({0}, {1})({2}, {3})", x2, y2, x1, y1);
            }
            else
            {
                Console.Write("({0}, {1})({2}, {3})", x1, y1, x2, y2);
            }
        }

        static double CalculateLineLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
        }

        static void Main(string[] args)
        {
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());
            double xC = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());
            double xD = double.Parse(Console.ReadLine());
            double yD = double.Parse(Console.ReadLine());

            double lineAB = CalculateLineLenght(xA, yA, xB, yB);
            double lineCD = CalculateLineLenght(xC, yC, xD, yD);

            if (lineAB > lineCD)
            {
                PrintLineClosestToCentre(xA, yA, xB, yB);
            }
            else if(lineCD > lineAB)
            {
                PrintLineClosestToCentre(xC, yC, xD, yD);
            }
            else
            {
                PrintLineClosestToCentre(xA, yA, xB, yB);
            }
            //String stopTheConsole = Console.ReadLine();

        }
    }
}
