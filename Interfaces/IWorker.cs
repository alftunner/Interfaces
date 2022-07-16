namespace Interfaces;

public interface IWorker
{
    bool IsWorking { get; }
    string Work();
}