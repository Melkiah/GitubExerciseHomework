using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentrePoint
{
    class Program
    {
        static double CalculateDistanceFromCentre(double x, double y)
        {
            double distance = 0.0;
            distance = Math.Sqrt(x*x + y*y);
            return distance;
        }

        static void PrintPointClosestToCentre(double x1, double y1, double x2, double y2)
        {
            double firstDistance = CalculateDistanceFromCentre(x1, y1);
            double secondDistance = CalculateDistanceFromCentre(x2, y2);

            if(firstDistance < secondDistance)
            {
                Console.WriteLine("({0}, {1})" ,x1,y1);
            }
            else if(secondDistance < firstDistance)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());            

            PrintPointClosestToCentre(x1,y1,x2,y2);

            String stopTheConsole = Console.ReadLine();
        }
    }
}
