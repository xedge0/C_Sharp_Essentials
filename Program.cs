using LinkedIn.Essentials;


// using dynamic variables

dynamic e = new
    {
    firstName = "Ahmed",
    lastName = "Dewedar",
    };

var kid1 = e.kids[0]; // raise Error on compile
Console.WriteLine(e.firstName);

