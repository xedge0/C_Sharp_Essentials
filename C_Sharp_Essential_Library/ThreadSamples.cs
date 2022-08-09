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
        Console.WriteLine("Work happening in main thread.");
        t.Join();
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

        Console.WriteLine($"Employee read from file: {edge?.FirstName} {edge?.LastName}");
        }
    }

