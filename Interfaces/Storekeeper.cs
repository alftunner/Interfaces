namespace Interfaces;

public class Storekeeper : Employee, IWorker
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
        return "Учитываю товар";
    }
}