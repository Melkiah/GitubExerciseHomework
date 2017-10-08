using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[8]
            {
                "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(daysOfWeek[input]);
    

        }
    }
}
