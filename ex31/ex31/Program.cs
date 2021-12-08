using System;
using System.IO;
using System.Collections.Generic;
using ex31.Entities;

namespace ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            Console.ReadLine();
            string path = "in.txt";

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}