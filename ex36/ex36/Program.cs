using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using ex36.Entities;

namespace ex36
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "in.csv";

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryFilter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than {0}:", salaryFilter.ToString("F2", CultureInfo.InvariantCulture));

            var emails = list.Where(p => p.Salary > salaryFilter).OrderBy(p => p.Email).Select(p => p.Email);

            foreach (var emailEmployee in emails)
            {
                Console.WriteLine(emailEmployee);
            }

            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M': {0}", sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
