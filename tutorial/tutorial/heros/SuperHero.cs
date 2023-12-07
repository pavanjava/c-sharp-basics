namespace tutorial;

public abstract class SuperHero
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;

    public void DisplayName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public abstract void Attack();
}