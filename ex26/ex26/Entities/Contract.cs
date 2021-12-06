using System;
using System.Collections.Generic;

namespace ex26.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }
    }
}