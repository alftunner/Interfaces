namespace Interfaces;

public class Employee : Human
{
    public string Position { get; set; }
    public double Salary { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"\nДолжность: {Position}\nЗарплата: {Salary}";
    }
}