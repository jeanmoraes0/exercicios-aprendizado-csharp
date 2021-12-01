using System;
using System.Globalization;
using System.Collections.Generic;
using ex20.Entities;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Taxpayers> taxpayers = new List<Taxpayers>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxpayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployess = int.Parse(Console.ReadLine());

                    taxpayers.Add(new Company(name, anualIncome, numberEmployess));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0;

            foreach (Taxpayers taxpayer in taxpayers)
            {
                Console.WriteLine($"{taxpayer.Name}: $ {taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");

                sum += taxpayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}