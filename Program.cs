using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "something|";
Console.WriteLine(PadAndTrim(input, 15, 'X'));

static string PadAndTrim([AllowNull] string input, int length, char padChar)
    {
    if(input is null)
        {
        return String.Empty.PadLeft(length, padChar);
        }

    else if(input.Length <= length && input != null)
        {
        switch(padChar)
            {
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') when padChar != 'X':
                return input.Trim().PadLeft(length, padChar);
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') when padChar == 'X':
                return String.Empty.PadLeft(length, '_');
            case (>= '0' and <= '9'):
                return input.Trim().PadRight(length, padChar);
            default:
                Console.WriteLine("No match found for pad character");
                break;
            }
        return input.Trim().PadLeft(length, padChar);
        }
    else
        {
        throw new ArgumentException("Input is longer than the requested length");
        }
    }

var shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
Console.WriteLine(shiftDay);

static ShiftDays GetShiftDays(DayOfWeek day) => day switch
    {
        DayOfWeek.Saturday => ShiftDays.Saturday,
        DayOfWeek.Sunday => ShiftDays.Sunday,
        DayOfWeek.Monday => ShiftDays.Monday,
        DayOfWeek.Tuesday => ShiftDays.Tuesday,
        DayOfWeek.Wednesday => ShiftDays.Wednesday,
        DayOfWeek.Thursday => ShiftDays.Thursday,
        DayOfWeek.Friday => ShiftDays.Friday,
        _ => throw new ArgumentException("Invalid day of the week supplied")
        };


var shiftNight = new DateTime(2022, 08, 06, 16, 0, 0);
Console.WriteLine($"Shift : {(IsWeekendNightShift(shiftNight) ? "is" : "is not")} a weekend night");

static bool IsWeekendNightShift(DateTime shiftDate) => shiftDate switch
    {
            { Hour: >= 15, DayOfWeek: DayOfWeek.Saturday or DayOfWeek.Friday } => true,
        _ => false
        };

IPerson sw = new ShiftWorker() { FirstName = "Ahmed", LastName = "Dewedar", StartDate = new DateOnly(2005, 01, 01) };
IPerson mgr = new Manager { FirstName = "mAhmed", LastName = "mDewedar", NumberOfDirectReports = 35 };
Console.WriteLine(GetPersonalDetails(sw));
Console.WriteLine(GetPersonalDetails(mgr));

static string GetPersonalDetails(IPerson p)
    {
    var result = p switch
        {
            ShiftWorker swv when swv.StartDate.Year > 2022 => $"Employee : {swv.FirstName} {swv.LastName} Started: {swv.StartDate}",
            ShiftWorker swv when swv.StartDate.Year < 2022 => $"Employee : {swv.FirstName} {swv.LastName} Started: Older Employee.",
            Manager mgrv => $"Manager : {mgrv.FirstName} {mgrv.LastName} Reports: {mgrv.NumberOfDirectReports}",
            _ => String.Empty
            };
    return result;
    }