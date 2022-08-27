while (true)
{
    Console.WriteLine("Enter the base currency:");
    string baseCurrency = Console.ReadLine().ToUpper();

    if (!exchangeRates.ContainsKey(baseCurrency))
    {
        Console.WriteLine("Invalid base currency. Try again.");
        continue;
    }
}