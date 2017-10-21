using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrade
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrades()
        {
            return this.Grades.Average();
        }
    }

    class AverageGrade
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> studentList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student studToAdd = ReadStudent();
                if (studToAdd.AverageGrades() >= 5.00)
                {
                    studentList.Add(studToAdd);
                }
            }

            var list = studentList.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrades());

            foreach (var item in list)
            {
                Console.WriteLine("{0:F2} -> {1:F2}", item.Name, item.AverageGrades());
            }
        }

        private static Student ReadStudent()
        {
            Student newStudent = new Student();
            string[] studentInfo = Console.ReadLine().Split().ToArray();
            newStudent.Name = studentInfo[0];
            List<double> gradesList = new List<double>();
            for (int j = 1; j < studentInfo.Length; j++)
            {
                gradesList.Add(double.Parse(studentInfo[j]));
            }
            newStudent.Grades = gradesList;

            return newStudent;
        }
    }
}