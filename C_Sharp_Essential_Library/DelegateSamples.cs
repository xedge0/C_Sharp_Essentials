namespace C_Sharp_Essential_Library;

public static class DelegateSamples
    {
    public delegate void Del(string input);

    public static void PassMeWork(Del work)
        {
        work("Delegates");
        }
    }
