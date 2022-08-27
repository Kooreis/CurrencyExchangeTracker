def get_exchange_rate(base_currency, target_currency):
    response = requests.get(f"https://api.exchangerate-api.com/v4/latest/{base_currency}")
    data = response.json()
    return data["rates"][target_currency]