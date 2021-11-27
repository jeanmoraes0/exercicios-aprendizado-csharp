using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();
            double diagonal = retangulo.Diagonal();
            
            Console.WriteLine("AREA = {0}", area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = {0}", perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}", diagonal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}