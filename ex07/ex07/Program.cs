using System.Globalization;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            ContaBancaria conta;

            if(op == 's')
            {
                Console.Write("Entre com o valor de depósito inicial ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroDaConta, nome, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroDaConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
             

        }
    }
}