using System;
using System.Globalization;
using ex17.Entities;
using System.Collections.Generic;

namespace ex17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outSourced = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outSourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}