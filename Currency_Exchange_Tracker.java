```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double exchangeRate;
        double amount;
        String currency;

        System.out.println("Welcome to Currency Exchange Tracker!");
        System.out.println("Please enter the exchange rate from USD to your desired currency:");
        exchangeRate = scanner.nextDouble();

        System.out.println("Please enter the amount in USD you want to convert:");
        amount = scanner.nextDouble();

        System.out.println("Please enter the name of your desired currency:");
        currency = scanner.next();

        double convertedAmount = amount * exchangeRate;

        System.out.println(amount + " USD is equivalent to " + convertedAmount + " " + currency + ".");
    }
}

class Currency {
    private String name;
    private double exchangeRate;

    public Currency(String name, double exchangeRate) {
        this.name = name;
        this.exchangeRate = exchangeRate;
    }

    public String getName() {
        return name;
    }

    public double getExchangeRate() {
        return exchangeRate;
    }
}
```