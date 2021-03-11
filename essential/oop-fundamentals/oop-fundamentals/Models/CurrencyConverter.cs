using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models
{
    public class CurrencyConverter
    {
        private double valueInHRN = default;


        public double ValueInUSD
        {
            get => valueInHRN / USD;
            set => valueInHRN = value * USD;
        }

        public double ValueInEUR
        {
            get => valueInHRN / EUR;
            set => valueInHRN = value * EUR;
        }

        public double ValueInRUB
        {
            get => valueInHRN / RUB;
            set => valueInHRN = value * RUB;
        }

        public double ValueInHRN
        {
            get => valueInHRN;
            set => valueInHRN = value;
        }


        public double USD { get; }

        public double EUR { get; }

        public double RUB { get; }


        public CurrencyConverter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

    }
}
