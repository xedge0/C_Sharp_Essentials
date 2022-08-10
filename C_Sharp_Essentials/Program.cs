using C_Sharp_Essential.Library;
using C_Sharp_Essential.Library.Extensions;

//var right = C_Sharp_Essential.Library.Extensions.StringExtensions.Right("Hello Four", 4);
//Console.WriteLine(right);

//var s = "right fives";
//Console.WriteLine(s.Right(5));

var names = new List<string> { "Edge", "Stone", "Alex", "Wall", "Xi" };

var shortest = names.MinBy((s) => s.Length);
Console.WriteLine($"Shortest Name : {shortest}");

var orderedNames = names.OrderBy(s => s.Length);
foreach (var name in orderedNames)
    {
    Console.WriteLine(name);
    }