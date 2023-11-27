namespace tutorial;

public class SimpleArrayDemo
{
    public String[] Initialize()
    {
        String[] data = { "Java", "C#", "Data Science", "JavaScript" };
        return data;
        
    }

    public void Display(String[] data, int index)
    {
        Console.WriteLine(data[index]);
    }

    public void SearchForElement(String[] data, String value)
    {
        Console.WriteLine(Array.IndexOf(data, value));
    }

    public void SortAndDisplay(String[] data)
    {
        Array.Sort(data);
        foreach (var s in data)
        {
            Console.WriteLine(s);
        }
    }

    public bool CompareArrays(String[] data1, String[] data2)
    {
        return Enumerable.SequenceEqual(data1, data2);
    }
    
}