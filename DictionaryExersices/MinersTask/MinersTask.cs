using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerLog = new Dictionary<string, int>();
            int count = 1;
            string key = ""; int value;
            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("stop"))
                {
                    break;
                }

                if (count % 2 != 0)
                {
                    key = input;
                }
                else
                {
                    value = int.Parse(input);
                    if (minerLog.ContainsKey(key))
                    {
                        int increace = value + minerLog[key];
                        minerLog[key] = increace;
                    }
                    else
                    {
                        minerLog.Add(key, value);
                    }

                }
                count++;
            }

            foreach (var item in minerLog)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
