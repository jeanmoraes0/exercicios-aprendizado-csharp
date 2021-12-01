namespace ex20.Entities
{
    class Company : Taxpayers
    {
        public int NumberEmployess { get; set; }

        public Company(string name, double anualIncome, int numberEmployess) : base(name, anualIncome)
        {
            NumberEmployess = numberEmployess;
        }

        public override double Tax()
        {
            if (NumberEmployess <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}