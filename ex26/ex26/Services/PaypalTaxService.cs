using ex26.Entities;

namespace ex26.Services
{
    class PaypalTaxService : ITaxService
    {
        private const double interestPerInstallment = 0.01;
        private const double interestOnPayment = 0.02;
        
        public double InterestPerInstallment(double amount, int months)
        {
            return amount * interestPerInstallment * months;
        }

        public double InterestOnPayment(double amount)
        {
            return amount * interestOnPayment;
        }
    }
}