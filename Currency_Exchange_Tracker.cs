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
    }
}