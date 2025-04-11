namespace System;
    
public class Station
{
    private static Station instance;
    private string stationName;
    private int totalSeats;
    private int soldTickets;

    private Station(string name, int seats)
    {
        stationName = name;
        totalSeats = seats;
        soldTickets = 0;
    }

    public static Station GetInstance(string name, int seats)
    {
        if (instance == null)
        {
            instance = new Station(name, seats);
        }
        return instance;
    }

    public void SellTicket()
    {
        if (soldTickets < totalSeats)
        {
            soldTickets++;
            Console.WriteLine("Билет продан.");
        }
        else
        {
            Console.WriteLine("Все билеты проданы.");
        }
    }

    public decimal GetUnsoldTicketsValue()
    {
        int unsold = totalSeats - soldTickets;
        return unsold * Ticket.Price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Станция: {stationName}");
        Console.WriteLine($"Всего мест: {totalSeats}");
        Console.WriteLine($"Продано билетов: {soldTickets}");
        Console.WriteLine($"Осталось билетов: {totalSeats - soldTickets}");
        Console.WriteLine($"Общая стоимость непроданных билетов: {GetUnsoldTicketsValue()} руб.");
    }
}
