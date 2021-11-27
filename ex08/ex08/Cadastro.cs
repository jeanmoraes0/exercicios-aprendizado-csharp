namespace ex08
{
    public class Cadastro
    {
        public string Nome {get; set;}
        public string Email {get; set;}

        public Cadastro(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}