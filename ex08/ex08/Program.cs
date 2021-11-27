using System;

namespace ex08
{
    class Program
    {
        static void Main()
        {
            Cadastro[] vect = new Cadastro[10];

            Console.Write("Quantos quartos deseja alugar? ");
            int qtAluguel = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtAluguel; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[quarto] = new Cadastro(nome, email);
            }

            Console.WriteLine("Quartos ocupados:");

            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }

        }
    }
}