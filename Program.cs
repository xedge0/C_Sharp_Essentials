using LinkedIn.Essentials;


// using var keyword and anonymous types

var e = new
    {
    firstName = "Ahmed",
    lastName = "Dewedar",
    kids = new string[] { "Edge", "xEdge" }
    };

var kid1 = e.kids[0];
Console.WriteLine(kid1);

