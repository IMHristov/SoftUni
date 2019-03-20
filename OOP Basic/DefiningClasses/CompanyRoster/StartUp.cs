using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string postion = input[2];
                string department = input[3];

                Employee employee = new Employee(name, salary, postion, department);

                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                        employee.Email = input[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(input[4]);
                    }
                }
                else if (input.Length == 6)
                {

                    employee.Email = input[4];
                    employee.Age = int.Parse(input[5]);

                }
                employees.Add(employee);

            }

            var topDepartment = employees.GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var emp in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
            }
        }
    }
}
