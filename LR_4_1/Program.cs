using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите название станции: ");
        string name = Console.ReadLine();
        Console.Write("Введите количество билетов: ");
        int seats = int.Parse(Console.ReadLine());
        Console.Write("Введите стоимость билета: ");
        decimal price = decimal.Parse(Console.ReadLine());
        
        Station station = Station.GetInstance(name, seats);
        Ticket.SetPrice(price);

        Console.WriteLine("Информация о вокзале:");
        station.DisplayInfo();
    
        Console.WriteLine("Продажа билетов...");
        station.SellTicket();
        station.SellTicket();
        
        Console.Write("Увеличить стоимость билета на: ");
        decimal increase = decimal.Parse(Console.ReadLine());
        Ticket.IncreasePrice(increase);

        Console.WriteLine("Обновленная информация:");
        station.DisplayInfo();
    }
}