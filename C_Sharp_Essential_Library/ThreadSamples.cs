using System.Text.Json;

namespace C_Sharp_Essential_Library;

public static class ThreadSamples
    {
    public static void SimpleThread()
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}");
        Console.ResetColor();

        Thread t = new Thread(DoFileWork);

        t.Start();
        t.Join();
        Console.WriteLine("Work happening in main thread.");
        Console.WriteLine("After all done");
        }

    public static void DoFileWork()
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"File access thread id: {Thread.CurrentThread.ManagedThreadId}");
        Console.ResetColor();

        string filePath = "..\\..\\..\\Edge.json";
        //this could take a while
        var employeeJson = File.ReadAllText(filePath);

        var edge = JsonSerializer.Deserialize<Employee>(employeeJson);

        Console.WriteLine($"The Employee {edge?.FirstName} {edge?.LastName}  has ID: {edge?.Id}");
        }
    public static async Task SimpleThreadAsync()
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Main Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        Console.ResetColor();

        Task tEdge =  DoFileWorkAsync("Edge");
        Task tAlex = DoFileWorkAsync("Alex");
        Console.WriteLine("Work happening on the main thread.");
        
        await Task.WhenAll(tEdge, tAlex);
        }
    public static async Task DoFileWorkAsync(string employeeName)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"File Access Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        Console.ResetColor();

        string filePath = $"..\\..\\..\\{employeeName}.json";
        var employeeJson = await File.ReadAllTextAsync(filePath);

        var edge = JsonSerializer.Deserialize<Employee>(employeeJson);
        Console.WriteLine($"The Employee {edge?.FirstName} {edge?.LastName}  has ID: {edge?.Id}");
        }
    }


