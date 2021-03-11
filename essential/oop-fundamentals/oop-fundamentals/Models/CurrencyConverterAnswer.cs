using oop_fundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop_fundamentals.Models
{
    public class CurrencyConverterAnswer : ITaskAnswer
    {
        public void Process()
        {
            const double USD_EXCHANGE_RATE = 27.76;
            const double RUB_EXCHANGE_RATE = 0.38;
            const double EUR_EXCHANGE_RATE = 33.15;


            var converter = new CurrencyConverter(USD_EXCHANGE_RATE, EUR_EXCHANGE_RATE, RUB_EXCHANGE_RATE);

            converter.ValueInHRN = 2777.3;

            Console.WriteLine($"{converter.ValueInHRN} hrn => usd: {converter.ValueInUSD}, rub: {converter.ValueInRUB}, eur: {converter.ValueInEUR}");

            converter.ValueInUSD = 100;

            Console.WriteLine($"{converter.ValueInHRN} hrn => usd: {converter.ValueInUSD}, rub: {converter.ValueInRUB}, eur: {converter.ValueInEUR}");

            converter.ValueInEUR = 100;

            Console.WriteLine($"{converter.ValueInHRN} hrn => usd: {converter.ValueInUSD}, rub: {converter.ValueInRUB}, eur: {converter.ValueInEUR}");

            converter.ValueInRUB = 100_000;

            Console.WriteLine($"{converter.ValueInHRN} hrn => usd: {converter.ValueInUSD}, rub: {converter.ValueInRUB}, eur: {converter.ValueInEUR}");

            converter.ValueInHRN = 45_000;

            Console.WriteLine($"{converter.ValueInHRN} hrn => usd: {converter.ValueInUSD}, rub: {converter.ValueInRUB}, eur: {converter.ValueInEUR}");
        }
    }
}
