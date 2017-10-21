using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesLabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "example.txt";

            string text = File.ReadAllText(path);
            

            Console.WriteLine(text);
        }
    }
}
