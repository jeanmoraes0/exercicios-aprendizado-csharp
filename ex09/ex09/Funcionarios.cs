using System.Globalization;

namespace ex09
{
    public class Funcionarios
    {
        public int Id {get; private set;}
        public string Nome {get; set;}
        public double Salario {get; private set;}

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}