namespace tutorial;

public class MultiDimentionalArrays
{
    // initialize and display normal multi dimentional array
    public void InitAndDisplayMultiDimArray(int rowIndex, int columnIndex)
    {
        try
        {
            String[,] languages =
            {
                { "Java", "Java Script" }, 
                { "Python", "C#" }
            };
        
            Console.WriteLine(languages[rowIndex,columnIndex]);
        }
        catch (Exception e) // handled exception for outside the bounds of array
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    // initialize and display normal jagged array (kind of multi dim array with fixed rows and dynamic number of columns)
    public void InitAndDisplayJaggedArray(int rowIndex, int columnIndex)
    {
        try
        {
            String[][] languages =
            {
                new []{"Java", "Spring Boot", "JPA"},
                new []{"Java Script", "ReactJS", "NodeJS", "NestJS", "ExpressJS", "Angular"},
                new []{"C#", "Blazor", "Entity Framework", "Web API"},
                new []{"MongoDB", "Cassandra"}
            };
        
            Console.WriteLine(languages[rowIndex][columnIndex]);
        }
        catch (Exception e) // handled exception for outside the bounds of array
        {
            Console.WriteLine(e);
            throw;
        }
    }
}