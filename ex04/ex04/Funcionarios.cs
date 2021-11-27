using System.Globalization;

namespace ex04
{
    public class Funcionarios
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * 0.1);
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}