using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines: ");
            int lines = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] vector = new int[lines, columns];

            Console.WriteLine("Enter vector lines, separated by space, press enter to change lines:");

            for (int i = 0; i < lines; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    vector[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();

            Console.Write("Enter the number you want to search for: ");
            int search = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (vector[i, j] == search)
                    {
                        Console.WriteLine($"Position: {i}, {j}:");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: {0}", vector[i, (j - 1)]);
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: {0}", vector[(i - 1), j]);
                        }

                        if (j + 1 < lines)
                        {
                            Console.WriteLine("Right: {0}", vector[i, (j + 1)]);
                        }

                        if (i + 1 < columns)
                        {
                            Console.WriteLine("Down: {0}", vector[(i + 1), j]);
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}