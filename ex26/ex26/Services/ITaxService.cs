namespace ex26.Services
{
    interface ITaxService
    {
        double InterestPerInstallment(double amount, int months);
        double InterestOnPayment(double amount);
    }
}