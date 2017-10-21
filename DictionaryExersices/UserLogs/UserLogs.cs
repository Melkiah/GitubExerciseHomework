using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class IPinfo
    {
        public string IP { get; set; }
        public string Message { get; set; }

        public IPinfo(string IP, string message)
        {
            this.IP = IP;
            this.Message = message;
        }
    }

    class UserLogs
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<IPinfo>> userLogs = new Dictionary<string, List<IPinfo>>();

            string input = "";

            while (true)
            {
                input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    break;
                }

                string[] command = input.Split();
                string username = command[2].Substring(5);
                string message = command[1].Substring(8);
                string IP = command[0].Substring(3);
                IPinfo ipInfo = new IPinfo(IP, message);
                List<IPinfo> infoList = new List<IPinfo>();

                if (!userLogs.ContainsKey(username))
                {
                    infoList.Add(ipInfo);
                    userLogs.Add(username, infoList);
                }
                else
                {
                    userLogs[username].Add(ipInfo);
                }
            }

            var list = userLogs.OrderBy(x => x.Key);

            foreach (var item in list)
            {
                Console.WriteLine(item.Key + ":");
                PrintIpOccurance(item.Value);
            }
        }

        private static void PrintIpOccurance(List<IPinfo> ipList)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in ipList)
            {
                if (!result.ContainsKey(item.IP))
                {
                    result.Add(item.IP, 1);
                }
                else
                {
                    result[item.IP]++;
                }
            }

            foreach (var item in result)
            {
                if (item.Key == result.Keys.Last())
                {
                    Console.WriteLine($"{item.Key} => {item.Value}.");

                }
                else
                {
                    Console.Write($"{item.Key} => {item.Value}, ");
                }
            }
        }
    }
}
