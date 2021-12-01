namespace ex20.Entities
{
    abstract class Taxpayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Taxpayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}