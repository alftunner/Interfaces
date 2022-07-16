namespace Interfaces;

public abstract class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return $"\nФамилия: {LastName}\nИмя: {FirstName}\nДата рождения: {BirthDate}";
    }
}