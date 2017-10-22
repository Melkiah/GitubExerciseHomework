using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class WorkingDays
    {
        static bool IsHoliday(DateTime day)
        {
            DateTime[] nonWorkingDays = new DateTime[11];
            nonWorkingDays[0] = new DateTime(2000, 1, 1);
            nonWorkingDays[1] = new DateTime(2000, 3, 3);
            nonWorkingDays[2] = new DateTime(2000, 5, 1);
            nonWorkingDays[3] = new DateTime(2000, 5, 6);
            nonWorkingDays[4] = new DateTime(2000, 5, 24);
            nonWorkingDays[5] = new DateTime(2000, 9, 6);
            nonWorkingDays[6] = new DateTime(2000, 9, 22);
            nonWorkingDays[7] = new DateTime(2000, 11, 1);
            nonWorkingDays[8] = new DateTime(2000, 12, 24);
            nonWorkingDays[9] = new DateTime(2000, 12, 25);
            nonWorkingDays[10] = new DateTime(2000, 12, 26);

            foreach (DateTime holliday in nonWorkingDays)
            {
                if (holliday.Day == day.Day && holliday.Month == day.Month)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workdaysCount = 0;



            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                string dayOfWeek = day.DayOfWeek.ToString();

                if (dayOfWeek == "Sunday" || dayOfWeek == "Saturday" || IsHoliday(day))
                {
                    continue;
                }

                workdaysCount++;
            }

            Console.WriteLine(workdaysCount);


            //Console.WriteLine(startDate);
            //Console.WriteLine(endDate);
        }
    }
}