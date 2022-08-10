namespace C_Sharp_Essential_Library;

public static class DelegateSamples
    {
    public static event Del SomethingHappened;
    public delegate void Del(string input);

    public static void PassMeWork(Del work)
        {
        work("Delegates");
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
