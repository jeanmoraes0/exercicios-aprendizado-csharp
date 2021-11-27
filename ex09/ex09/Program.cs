using System;
using System.Collections.Generic;
using System.Globalization;

namespace ex09
{
    class Program
    {
        static void Main()
        {
            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            Console.Write("Quantos funcionarios deseja cadastrar? ");
            int qtFuncionarios = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtFuncionarios; i++)
            {
                Console.WriteLine($"Funcionario {i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionarios.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine();
            
            Console.Write("Entre com o id do funcionario que deseja efetuar o aumento de salario: ");
            int pesquisaId = int.Parse(Console.ReadLine());

            int posicao = listaFuncionarios.FindIndex(x => x.Id == pesquisaId);

            if(posicao != -1)
            {
                Console.Write("Entre com a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionarios[posicao].Aumento(porcentagem);
            }
            else
            {
                Console.WriteLine("Este id não existe!");
            }

            Console.WriteLine("Lista de funcionarios:");

            foreach(Funcionarios funcionario in listaFuncionarios)
            {
                Console.WriteLine(funcionario);
            }


            
        }
    }
}