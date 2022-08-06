using LinkedIn.Essentials;

string input = null;
int definitiveInt;

int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12; // if value is null, assign a default value
definitiveInt = age ?? 17; // if age is null, assign a default value
//definitiveInt = age != null ? age.Value : 17; // same logic

Console.WriteLine(definitiveInt);

if(age != null) { Console.WriteLine($"{age}"); }
if(age.HasValue) { Console.WriteLine(age.Value); }