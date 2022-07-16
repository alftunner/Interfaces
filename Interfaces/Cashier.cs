namespace Interfaces;

public class Cashier : Employee, IWorker
{
    public bool isWorking = true;

    public bool IsWorking
    {
        get
        {
            return isWorking;
        }
    }

    public string Work()
    {
        return "Принимаю оплату за товар";
    }
}