using System;
using System.Collections.Generic;
using ex32.Entities;

namespace ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Alunos> cursoA = new HashSet<Alunos>();
            HashSet<Alunos> cursoB = new HashSet<Alunos>();
            HashSet<Alunos> cursoC = new HashSet<Alunos>();

            Console.Write("Quantos estudantes matriculado no curso A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numeroDeMatricula = int.Parse(Console.ReadLine());
                cursoA.Add(new Alunos(numeroDeMatricula));
            }

            Console.Write("Quantos estudantes matriculado no curso B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numeroDeMatricula = int.Parse(Console.ReadLine());
                cursoB.Add(new Alunos(numeroDeMatricula));
            }

            Console.Write("Quantos estudantes matriculado no curso C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numeroDeMatricula = int.Parse(Console.ReadLine());
                cursoC.Add(new Alunos(numeroDeMatricula));
            }

            HashSet<Alunos> total = new HashSet<Alunos>();
            total.UnionWith(cursoA);
            total.UnionWith(cursoB);
            total.UnionWith(cursoC);

            Console.WriteLine("Total: " + total.Count);
        }
    }
}