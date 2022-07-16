﻿namespace Interfaces;

public interface IManager
{
    List<IWorker> ListOfWorkers { get; set; }
    void Organize();
    void MakeBudget();
    void Control();
}