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

            // display using traditional for loop
            for (int i = 0; i < languages.GetLength(0); i++)
            {
                for (int j = 0; j < languages.GetLength(1); j++)
                {
                    Console.Write(languages[i,j]+ " ");        
                }
                Console.WriteLine();
            }
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
                new[] { "Java", "Spring Boot", "JPA" },
                new[] { "Java Script", "ReactJS", "NodeJS", "NestJS", "ExpressJS", "Angular" },
                new[] { "C#", "Blazor", "Entity Framework", "Web API" },
                new[] { "MongoDB", "Cassandra" }
            };

            // display using traditional for loop
            for (int i = 0; i < languages.Length; i++)
            {
                for (int j = 0; j < languages[i].Length; j++)
                {
                    Console.Write(languages[i][j]+ " ");        
                }
                Console.WriteLine();
            }
        }
        catch (Exception e) // handled exception for outside the bounds of array
        {
            Console.WriteLine(e);
            throw;
        }
    }
}