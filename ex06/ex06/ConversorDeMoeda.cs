namespace ex06
{
    public class ConversorDeMoeda
    {
        public static double Conversor(double dolar, double quantidade)
        {
            return (dolar * quantidade) + ((dolar * quantidade) * 0.06);
        }
    }
}