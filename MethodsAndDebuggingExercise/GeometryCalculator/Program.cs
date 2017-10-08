using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double GeometryCalculation(double side, string instruction)
        {

            switch (instruction)
            {
                case "volume": return side * side * side; break;
                case "face": return Math.Sqrt(side * side * 2); break;
                case "area": return 6 * side * side; break;
                case "space": return Math.Sqrt(3 * side * side); break;
                default: return 0;

            }
        }

        static void Main(string[] args)
        {
            string instruction = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.

            GeometryCalculation()
        }
    }
}
