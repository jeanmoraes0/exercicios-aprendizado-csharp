using System.Globalization;

namespace ex07
{
    public class ContaBancaria
    {
        public int NumeroDaConta {get; private set;}
        public string Nome {get; set;}
        public double Saldo {get; private set;}

        public ContaBancaria(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroDaConta, string nome, double deposito) : this(numeroDaConta, nome)
        {
            Deposito(deposito);
        }

       public void Deposito(double valor)
       {
           Saldo += valor;
       }

       public void Saque(double valor)
       {
           Saldo -= valor + 5.00;
       }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }

    }
}