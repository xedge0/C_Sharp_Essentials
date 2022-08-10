using C_Sharp_Essential_Library;

//Console.WriteLine("Hit Ctrl + C to cancel");
//Console.CancelKeyPress += OnCancel;

//Delegate del = WritingHello;
//del.DynamicInvoke("Ahmed");
//DelegateSamples.PassMeWork(WritingHello);

//static void WritingHello(string name)
//    {
//    Console.WriteLine($"Hello, {name}");
//    DelegateSamples.SomethingHappened -= WritingHello; 
//    }

//DelegateSamples.SomethingHappened += WritingHello;
//DelegateSamples.DoSomething();

//for(int i = 0; i < 100000; i++)
//    {
//    Console.WriteLine(i);
//    }

//static void OnCancel(object sender, ConsoleCancelEventArgs args)
//    {
//    args.Cancel = false; //true
//    Console.CancelKeyPress -= OnCancel;
//    }

static void Writing(string input)
    {
    Console.WriteLine($"Hello, {input}");
    }

DelegateSamples.PassMeWork(Writing);
DelegateSamples.PassMeLogic(CalcLength);

static int CalcLength(string input)
    {
    return input.Length;
    }

var t = (string s) => Console.WriteLine(s);
t("Edge");

var l = (string s) => s.Length;

var r = (string s) =>
{
    Console.WriteLine(s);
    return s.Length;
};

