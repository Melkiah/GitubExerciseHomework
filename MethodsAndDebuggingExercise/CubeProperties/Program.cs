using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static double CubeProperties(double side, string instruction)
        {         

            switch (instruction)
            {
                case "volume": return side * side * side; break;
                case "face": return Math.Sqrt(side*side*2);break;
                case "area": return  6 * side * side;break;
                case "space": return  Math.Sqrt(3 * side * side);break;
                default: return 0;

            }
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string instruction = Console.ReadLine().ToLower();

            double result = CubeProperties(side, instruction);

            Console.WriteLine(result);
        }        
    }
}
