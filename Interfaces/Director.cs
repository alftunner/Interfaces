namespace Interfaces;

public class Director : Employee, IManager
{
    public List<IWorker> ListOfWorkers { get; set; }
    public void Organize()
    {
        Console.WriteLine("Организую работу!");
    }

    public void MakeBudget()
    {
        Console.WriteLine("Формирую бюджет!");
    }

    public void Control()
    {
        Console.WriteLine("Контролирую работу!");
    }
}