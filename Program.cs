using C_Sharp_Essentials;

CollectionSamples.Queue();
CollectionSamples.Stack();
Console.WriteLine();
//return; // skip code

string[] names = new string[2];
names[0] = "Alex";
names[1] = "Stone";

Console.WriteLine($"Hello {names[0]}, {names[1]}");

var al = new System.Collections.ArrayList(2);
al.Add("First");
al.Add("Second");
al.Add("Third");
al.AddRange(new string[] { "rSecond", "rThird", "rFourth", "rFifth" });

Console.WriteLine($"Collection Size : {al.Count}");
Console.WriteLine($"Indexed Items from the collections {al[4]}");
Console.WriteLine("All Items from collections");
foreach(var item in al)
    {
    Console.Write($"{item} ");
    }
