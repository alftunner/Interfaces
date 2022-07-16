namespace Interfaces;

public class Seller : Employee, IWorker
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
        return "Продаю товар";
    }
}