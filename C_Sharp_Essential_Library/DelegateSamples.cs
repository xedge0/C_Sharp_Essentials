namespace C_Sharp_Essential_Library;

public static class DelegateSamples
    {
    public static event Action<string> SomethingHappened;
    
    //public delegate void Del(string input);

    public static void PassMeWork(Action<string> work)
        {
        work("Delegates");
        }

    public static void PassMeLogic(Func<string, int> worker)
        {
        var count = worker("Hello Edge");
        Console.WriteLine($"String length is : {count}");
        }

    public static void DoSomething()
        {
        Console.WriteLine("I'am about to do something.");
        if (SomethingHappened != null)
            {
            SomethingHappened("I did something");
            }
        }
    }
