using System;

public class Ticket
{
    private static decimal price;

    public static decimal Price
    {
        get { return price; }
    }

    public static void SetPrice(decimal newPrice)
    {
        if (newPrice > 0)
            price = newPrice;
    }
    public static void IncreasePrice(decimal amount)
    {
        price += amount;
    }

    public static void DecreasePrice(decimal amount)
    {
        if (price - amount > 0)
            price -= amount;
    }
}
