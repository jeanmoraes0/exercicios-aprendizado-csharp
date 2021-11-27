using System.Globalization;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1 = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Salário médio = {0}", ((funcionario1.salario + funcionario2.salario) / 2.0).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}