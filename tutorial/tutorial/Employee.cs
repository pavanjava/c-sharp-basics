using System.Text;

namespace tutorial;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<string> languagesKnown { get; set; }

    public void display()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var language in languagesKnown)
        {
            stringBuilder.Append(language).Append(",");
        }
        Console.WriteLine($"Name: {FirstName} {LastName}, Languages Known: {stringBuilder.Remove(stringBuilder.Length-1,1)}");
    }
}