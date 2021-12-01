using System;
using System.Globalization;
using System.Collections.Generic;
using ex18.Entities;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (op)
                {
                    case 'i':
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;
                    default:
                        products.Add(new Product(name, price));
                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}