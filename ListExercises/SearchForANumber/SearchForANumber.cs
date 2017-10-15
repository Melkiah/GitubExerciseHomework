using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {

            string yes = "YES!";
            string no = "NO!";

            bool isFound = false;
            int[] commands = new int[3];

            List<int> numbersArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = commands[1]; i < commands[0]; i++)
            {
                if (numbersArray[i] == commands[2])
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine(yes);
            }
            else
            {
                Console.WriteLine(no);
            }
        }
    }
}
