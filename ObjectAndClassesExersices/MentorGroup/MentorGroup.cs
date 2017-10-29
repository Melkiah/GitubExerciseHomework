using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Student
    {
        //public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendances { get; set; }

        public Student()
        {
            //this.Name = name;
            this.Comments = new List<string>();
            this.Attendances = new List<DateTime>();
        }
    }

    class MentorGroup
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentList = new Dictionary<string, Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("end of dates"))
                {
                    break;
                }

                string[] attendanceList = input.Split(' ', ',');
                string studentName = attendanceList[0];
                List<DateTime> attendList = new List<DateTime>();
                Student newStudent = new Student();
                for (int i = 1; i < attendanceList.Length; i++)
                {
                    attendList.Add(DateTime.ParseExact(attendanceList[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (!studentList.ContainsKey(studentName))
                {
                    studentList.Add(studentName, newStudent);
                    studentList[studentName].Attendances = attendList;
                }
                else
                {
                    foreach (DateTime item in attendList)
                    {
                        studentList[studentName].Attendances.Add(item);
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (input[0].Equals("end of comments"))
                {
                    break;
                }
                string studentName = input[0];
                string comment = input[1];

                if (!studentList.ContainsKey(studentName))
                {
                    continue;
                }

                studentList[studentName].Comments.Add(comment);
            }

            foreach (KeyValuePair<string, Student> item in studentList.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Comments:");
                foreach (string comment in item.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (DateTime attendance in item.Value.Attendances.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {attendance:dd/MM/yyyy}");
                }
            }
        }
    }
}
