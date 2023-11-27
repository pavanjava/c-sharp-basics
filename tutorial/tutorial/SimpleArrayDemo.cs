namespace tutorial;

public class SimpleArrayDemo
{
    public String[] Initialize()
    {
        String[] data = new[] { "Java", "C#", "Data Science", "JavaScript" };
        return data;
        
    }

    public void Display(String[] data, int index)
    {
        Console.WriteLine(data[index]);
    }
    
}