using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double GeometryCalculation(string instruction, double a, double b)
        {

            switch (instruction)
            {
                case "triangle": return (a * b) / 2;
                //case "square": return a * b;
                case "rectangle": return a * b;
                //case "circle": return Math.PI * a * b;
                default: return 0;

            }
        }

        static double GeometryCalculation(string instruction, double a)
        {
            switch (instruction)
            {
                //case "triangle": return (a * b) / 2;
                case "square": return a * a;
                //case "rectangle": return a * b;
                case "circle": return Math.PI * a * a;
                default: return 0;

            }
        }

        static void Main(string[] args)
        {
            string instruction = Console.ReadLine().ToLower();
            double a = double.Parse(Console.ReadLine());
            if(instruction == "square" || instruction == "circle")
            {
                double result = GeometryCalculation(instruction, a);

                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                double b = double.Parse(Console.ReadLine());
                double result = GeometryCalculation(instruction, a, b);
                Console.WriteLine("{0:F2}", result);
            }
            

            
        }
    }
}
