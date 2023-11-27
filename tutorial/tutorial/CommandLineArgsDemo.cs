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
        
    }
}