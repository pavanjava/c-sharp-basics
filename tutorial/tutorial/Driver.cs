using System.Collections;

namespace tutorial;

public class Driver
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.FirstName = "Pavan Kumar";
        employee.LastName = "Mantha";
        employee.languagesKnown = new List<string>() { "Java", "C#", "Java Script", "Data Science" };
        
        employee.display();
    }
}