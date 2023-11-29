namespace tutorial;

public class Driver
{
    static void Main(string[] args)
    {
        // const string str = "This the demo of \"String\" basics";
        // const string str = @"will save all the data in usr:\pavans\";

        // String interpolation expression
        const string first = "First";
        const string second = "Second";
        const string str = $"{first} = {second}";
        Console.WriteLine(str);

        string currency = string.Format("{0:C}", 546.23);
        Console.WriteLine(currency);
        
        string number = string.Format("{0:N}", 8754576543467899876);
        Console.WriteLine(number);
        
        string percentage = string.Format("{0:P}", 79.82);
        Console.WriteLine(percentage);

        string demoString = " I started learning C# programing language ";
        Console.WriteLine(demoString.Length);
        Console.WriteLine(demoString.ToUpper());
        Console.WriteLine(demoString.ToLower());
        Console.WriteLine(demoString.Replace("C#", "C Sharp"));
        Console.WriteLine($"Length Before: {demoString.Length}, Length After {demoString.Trim().Length}");
    }
}