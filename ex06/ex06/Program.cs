using System.Globalization;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação atual do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = {0}", ConversorDeMoeda.Conversor(cotacao, qtDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}