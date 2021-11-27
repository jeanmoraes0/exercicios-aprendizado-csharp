using System.Globalization;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = {0}", aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if(aluno.VerifiarAprovacao())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", (60 - aluno.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}