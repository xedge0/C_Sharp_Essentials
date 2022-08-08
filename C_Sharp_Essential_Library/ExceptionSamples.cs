namespace C_Sharp_Essential_Library;

using System.Text.Json;

public static class ExceptionSamples
    {
    public static void BasicExceptions()
        {
        string wrongPath = "Edge.json";
        string rightPath = "..\\..\\..\\Edge.json";

        //basic try catch
        string filePath = rightPath;
        System.IO.Stream fileStream = null;
        Console.WriteLine($"Current Directory-> {Directory.GetCurrentDirectory()}");
        try
            {
            fileStream = File.OpenRead(filePath);

            var edge = JsonSerializer.Deserialize<Employee>(fileStream);

            Console.WriteLine($"Employee read from file: {edge?.FirstName} {edge?.LastName}");
            }
        catch(Exception ex)
            {
            Console.WriteLine($"Standard exception caught: {ex.Message}");
            }
        finally
            {
            if(fileStream != null)
                {
                fileStream.Dispose();
                }
            }
        }
    }