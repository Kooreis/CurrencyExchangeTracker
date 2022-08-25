```python
import requests
import json

def get_exchange_rate(base_currency, target_currency):
    response = requests.get(f"https://api.exchangerate-api.com/v4/latest/{base_currency}")
    data = response.json()
    return data["rates"][target_currency]

def main():
    print("Welcome to Currency Exchange Tracker")
    base_currency = input("Enter base currency: ")
    target_currency = input("Enter target currency: ")
    amount = float(input("Enter the amount: "))
    exchange_rate = get_exchange_rate(base_currency, target_currency)
    converted_amount = amount * exchange_rate
    print(f"{amount} {base_currency} is equal to {converted_amount} {target_currency}")

if __name__ == "__main__":
    main()
```