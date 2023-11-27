namespace tutorial;

public class CommandLineArgsDemo
{
    static void Main(String[] args)
    {
        int sum = 0;
        foreach (var s in args)
        {
            sum += int.Parse(s);
        }
        Console.WriteLine(sum);
        
        // calling the other class array methods
        SimpleArrayDemo simpleArrayDemo = new SimpleArrayDemo();
        String[] data = simpleArrayDemo.Initialize();
        simpleArrayDemo.Display(data, 1);
        
        // find the index of specific element
        simpleArrayDemo.SearchForElement(data, "JavaScript");

        // sort the Array elements
        simpleArrayDemo.SortAndDisplay(data);
        
        // check if two arrays are same or not
        String[] data2 = { "Java", "C#", "Data Science", "JavaScript" };
        // Array.Sort(data2); uncomment if you want `True`, as our original data is already sorted we have to sort the second array also
        Console.WriteLine(simpleArrayDemo.CompareArrays(data, data2));
    }
}