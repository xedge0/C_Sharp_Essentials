using LinkedIn.Essentials;

string input = null;
int definitiveInt;

int? age = null;
Nullable<int> age2 = null;

age = 17;

if(input != null) { Console.WriteLine($"String is : {input}"); }
if(age != null) { Console.WriteLine($"{age}"); }
if(age.HasValue) { Console.WriteLine(age.Value); }