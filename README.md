# Python Documentation

# Currency Exchange Tracker

This Python script allows users to convert a specified amount from one currency to another using the latest exchange rates.

## Description

The script prompts the user to input a base currency, a target currency, and an amount. It then fetches the latest exchange rate for the specified currencies from the ExchangeRate-API, calculates the converted amount, and displays the result.

## Libraries Used

- `requests`: This library is used to send HTTP requests. In this script, it is used to fetch the latest exchange rates from the ExchangeRate-API.

- `json`: This library is used to work with JSON data. In this script, it is used to parse the JSON response received from the ExchangeRate-API.

## Functions

- `get_exchange_rate(base_currency, target_currency)`: This function takes in two parameters, the base currency and the target currency. It sends a GET request to the ExchangeRate-API and returns the exchange rate for the specified currencies.

- `main()`: This is the main function of the script. It prompts the user to input the base currency, target currency, and amount. It then calls the `get_exchange_rate()` function to get the exchange rate, calculates the converted amount, and prints the result.

## Usage

To run the script, simply execute the following command:

```bash
python currency_exchange_tracker.py
```

Then, follow the prompts to input the base currency, target currency, and amount.

## Note

This script assumes that the user inputs valid currency codes and a valid amount. It does not handle errors that may occur if invalid inputs are provided.

---

# C# Documentation

# Currency Converter in C#

This is a simple console application written in C# that converts an amount from one currency to another based on predefined exchange rates.

## Script Explanation

The script prompts the user to input a base currency, a target currency, and an amount. It then calculates the equivalent amount in the target currency based on the exchange rates defined in the script. The script will continue to prompt the user for inputs until the program is manually terminated.

## Code Breakdown

The script uses two namespaces:

- `System`: This namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.
- `System.Collections.Generic`: This namespace contains interfaces and classes that define generic collections, which allow users to create strongly typed collections that provide better type safety and performance than non-generic strongly typed collections.

The script defines a `Dictionary` named `exchangeRates` that contains the exchange rates for USD, EUR, JPY, and GBP. The `Dictionary` class is a part of the `System.Collections.Generic` namespace and is used to store key-value pairs.

The script then enters an infinite loop where it prompts the user for the base currency, target currency, and amount. If the user enters an invalid base currency, target currency, or amount, the script will print an error message and prompt the user for the input again.

The script calculates the equivalent amount in the target currency by multiplying the amount by the ratio of the exchange rate of the target currency to the exchange rate of the base currency. The result is then printed to the console.

## Usage

To use the script, simply run it in a C# compatible environment. When prompted, enter the base currency, target currency, and amount as instructed. The script will then print the equivalent amount in the target currency.

---

# Java Documentation

# Currency Exchange Tracker

This is a simple Java program that allows users to convert an amount from US Dollars (USD) to a desired currency. The user is required to input the exchange rate from USD to the desired currency, the amount in USD they want to convert, and the name of the desired currency. The program then calculates and displays the equivalent amount in the desired currency.

## Script Explanation

The script is divided into two classes: `Main` and `Currency`.

### Main Class

The `Main` class is the entry point of the program. It creates a `Scanner` object for user input and prompts the user to enter the exchange rate, the amount in USD, and the name of the desired currency. It then calculates the equivalent amount in the desired currency and displays it.

### Currency Class

The `Currency` class is a simple data class that represents a currency. It has two fields: `name` and `exchangeRate`, and corresponding getter methods. However, this class is not used in the current version of the program.

## Imported Libraries

### java.util.Scanner

The `java.util.Scanner` class is a simple text scanner which can parse primitive types and strings. It is used in this program to get user input from the console.

## Usage

To use this program, simply run the `Main` class. You will be prompted to enter the exchange rate from USD to your desired currency, the amount in USD you want to convert, and the name of your desired currency. After entering these details, the program will display the equivalent amount in the desired currency.

---
