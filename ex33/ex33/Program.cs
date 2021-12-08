using System;
using System.IO;
using System.Collections.Generic;

namespace ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "in.csv";

            Dictionary<string, int> dic = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int value = int.Parse(line[1]);

                        if (dic.ContainsKey(name))
                        {
                            dic[name] += value;
                        }
                        else
                        {
                            dic.Add(name, value);
                        }
                    }
                }

                foreach (KeyValuePair<string, int> item in dic)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}