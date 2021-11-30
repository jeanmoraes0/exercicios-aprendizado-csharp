using System.Globalization;

namespace ex17.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHours { get; set; }

        public Employee() { }

        public Employee(string name, int hours, double valuePerHours)
        {
            Name = name;
            Hours = hours;
            ValuePerHours = valuePerHours;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHours;
        }

        public override string ToString()
        {
            return Name
                + " - $ "
                + this.Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}