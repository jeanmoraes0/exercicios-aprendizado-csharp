using System;
using ex26.Entities;

namespace ex26.Services
{
    class ContractService
    {
        private ITaxService _taxService;

        public ContractService(ITaxService _taxService)
        {
            this._taxService = _taxService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _taxService.InterestPerInstallment(basicQuota, i);
                double fullQuota = updatedQuota + _taxService.InterestOnPayment(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}