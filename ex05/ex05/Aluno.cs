using System.Globalization;

namespace ex05
{
    public class Aluno
    {
        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal()
        {
            return (PrimeiroTrimestre + SegundoTrimestre + TerceiroTrimestre);

        }

        public bool VerifiarAprovacao()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            }

            return false;
        }
    }
}