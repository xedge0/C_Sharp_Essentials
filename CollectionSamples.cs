namespace C_Sharp_Essentials;

public static class CollectionSamples
    {
    public static void Queue()
        {
        var q = new System.Collections.Generic.Queue<string>();
        q.Enqueue("firstItem");
        q.Enqueue("secondItem");

        string? item = null;

        Console.WriteLine("Using a Queue");
        while((item = q.Dequeue()) != null)
            {
            Console.WriteLine(item);
            if(q.Count <= 0)
                break;
            }
        }

    public static void Stack()
        {
        var stk = new System.Collections.Generic.Stack<string>();
        stk.Push("firstItem");
        stk.Push("secondItem");

        string? stkItem = null;
        Console.WriteLine();
        Console.WriteLine("Using a stack");

        while((stkItem = stk.Pop()) != null)
            {
            Console.WriteLine(stkItem);
            if(stk.Count <= 0)
                break;
            }
        }
    }
