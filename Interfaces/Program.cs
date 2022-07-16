using Interfaces;

Director director = new Director
{
    LastName = "Путин",
    FirstName = "Вовка",
    BirthDate = new DateTime(1970, 10, 12),
    Position = "Директор",
    Salary = 12000000000000000000000.0
};

IWorker seller = new Seller
{
    LastName = "Задорожный",
    FirstName = "Андрей",
    BirthDate = new DateTime(1994, 02, 18),
    Position = "Продавец",
    Salary = 120
};

if (seller is Employee)
{
    Console.WriteLine($"Заработная плата продавца: {(seller as Employee).Salary}");
}

director.ListOfWorkers = new List<IWorker>
{
    seller,
    new Cashier
    {
        LastName = "Шерстнёв",
        FirstName = "Алексей",
        BirthDate = new DateTime(1992, 06, 08),
        Position = "Кассир",
        Salary = 110
    },
    new Storekeeper
    {
        LastName = "Сэндлер",
        FirstName = "Адам",
        BirthDate = new DateTime(1975, 06, 08),
        Position = "Кладовщик",
        Salary = 100
    }
};

Console.WriteLine(director);

if (director is IManager)
{
    director.Control();
}

foreach(IWorker item in director.ListOfWorkers) {
    Console.WriteLine(item);
    if (item.IsWorking)
    {
        Console.WriteLine(item.Work());
    }
}