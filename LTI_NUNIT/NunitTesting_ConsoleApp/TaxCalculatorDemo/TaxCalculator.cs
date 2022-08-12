using System;

namespace TaxCalculatorDemo
{
    public class TaxCalculator
    {
        public int Amount { get; set; }

        public int Tax { get; set; }

        public TaxCalculator(int amount,int tax)
        {
            this.Amount = amount;
            this.Tax = tax;
        }

        public int GetTax()
        {
            return Amount * Tax / 100;
        }


    }
}
