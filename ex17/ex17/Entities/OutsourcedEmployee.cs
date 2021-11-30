namespace ex17.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.10;
        }
    }
}