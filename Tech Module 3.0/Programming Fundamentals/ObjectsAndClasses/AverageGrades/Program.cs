using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_AverageGrades
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> excelentStudents = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                string studentName = input[0];

                input.Remove(input[0]);

                List<double> listGrades = input.Select(double.Parse).ToList();

                Student student = new Student(studentName, listGrades);

                if (student.AverageGrade >= 5.00)
                {
                    excelentStudents.Add(student);
                }
            }

            excelentStudents = excelentStudents
                .OrderBy(st => st.Name)
                .ThenByDescending(st => st.AverageGrade)
                .ToList();

            foreach (var student in excelentStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string studentName, List<double> listGrades)
        {
            Name = studentName;
            ListGrades = listGrades;
            AverageGrade = listGrades.Average();
        }
        public string Name { get; set; }
        public List<double> ListGrades { get; set; }
        public double AverageGrade { get; set; }
    }
}