```CSharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>()
        {
            { "USD", 1.00m },
            { "EUR", 0.85m },
            { "JPY", 110.08m },
            { "GBP", 0.72m }
        };

        while (true)
        {
            Console.WriteLine("Enter the base currency:");
            string baseCurrency = Console.ReadLine().ToUpper();

            if (!exchangeRates.ContainsKey(baseCurrency))
            {
                Console.WriteLine("Invalid base currency. Try again.");
                continue;
            }

            Console.WriteLine("Enter the target currency:");
            string targetCurrency = Console.ReadLine().ToUpper();

            if (!exchangeRates.ContainsKey(targetCurrency))
            {
                Console.WriteLine("Invalid target currency. Try again.");
                continue;
            }

            Console.WriteLine("Enter the amount:");
            decimal amount;
            if (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Invalid amount. Try again.");
                continue;
            }

            decimal result = amount * (exchangeRates[targetCurrency] / exchangeRates[baseCurrency]);
            Console.WriteLine($"{amount} {baseCurrency} = {result} {targetCurrency}");
        }
    }
}
```