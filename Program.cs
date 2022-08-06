using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = null;
int definitiveInt;

int? age = null;
Nullable<int> age2 = null;

age = 5;
age ??= 12; // if value is null, assign a default value
definitiveInt = age ?? 17; // if age is null, assign a default value
//definitiveInt = age != null ? age.Value : 17; // same logic

Console.WriteLine($"Age is : {definitiveInt}");
Console.WriteLine(PadAndTrim(input, 15, '0'));

static string PadAndTrim([AllowNull]string input, int length, char padChar)
    {
    if (input == null)
        return String.Empty.PadLeft(length, padChar);
    else
        return input.Trim().PadLeft(length, padChar);

    //return input?.Trim()?.PadLeft(length, padChar); //if input or trim is null do not run

    }