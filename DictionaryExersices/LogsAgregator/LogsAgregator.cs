using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAgregator
{
    //class User
    //{
    //    public string Name { get; set; }
    //    public List<string> IPs { get; set; }
    //    public int Duration { get; set; }

    //    public User(string name)
    //    {
    //        this.Name = name;
    //        this.Duration = 0;
    //        this.IPs = new List<string>();
    //    }
    //}

    class LogsAgregator
    {
        public static bool ContainsUser(SortedDictionary<string, List<string>> userLog, string username)
        {
            foreach (var item in userLog)
            {
                if (item.Key == username)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> userLogs = new SortedDictionary<string, List<string>>();
            Dictionary<string, int> userDuration = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string userName = input[1];
                string ip = input[0];
                int duration = int.Parse(input[2]);

                if (!ContainsUser(userLogs, userName))
                {
                    userLogs.Add(userName, new List<string>());
                    userDuration.Add(userName, duration);
                    if (!ContainsIp(userLogs[userName], ip))
                    {
                        userLogs[userName].Add(ip);
                    }

                }
                else
                {
                    userDuration[userName] += duration;
                    if (!ContainsIp(userLogs[userName], ip))
                    {
                        userLogs[userName].Add(ip);
                    }
                }
            }
            

            foreach (var item in userLogs.Keys)
            {
                Console.Write($"{item}: ");
                Console.Write($"{userDuration[item]} ");
                var list = userLogs[item].OrderBy(x => x);
                Console.WriteLine("[" + String.Join(", ",list )+ "]");
            }

        }

        public static bool ContainsIp(List<string> list, string ip)
        {
            foreach (var item in list)
            {
                if (item == ip)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
