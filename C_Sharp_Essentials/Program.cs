using C_Sharp_Essential_Library;

Delegate del = WritingHello;
del.DynamicInvoke("Ahmed");
DelegateSamples.PassMeWork(WritingHello);

static void WritingHello(string name)
    {
    Console.WriteLine($"Hello, {name}");
    }

