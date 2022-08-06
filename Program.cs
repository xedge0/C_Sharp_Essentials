using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "something|";

Console.WriteLine(PadAndTrim(input, 15, '0'));

var shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
//var shiftDay = GetShiftDays((DayOfWeek)17); // throw exception
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
            case (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'):
                return input.Trim().PadLeft(length, padChar);
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

IPerson sw = new ShiftWorker() { FirstName = "Ahmed", LastName = "Dewedar", StartDate = new DateOnly(2005, 01, 01) };
IPerson mgr = new Manager { FirstName = "mAhmed", LastName = "mDewedar", NumberOfDirectReports = 35 };

Console.WriteLine(GetPersonalDetails(sw));
Console.WriteLine(GetPersonalDetails(mgr));

static string GetPersonalDetails(IPerson p)
    {
    var result = p switch
        {
            ShiftWorker swv => $"Employee : {swv.FirstName} {swv.LastName} Started: {swv.StartDate}",
            Manager mgrv => $"Manager : {mgrv.FirstName} {mgrv.LastName} Reports: {mgrv.NumberOfDirectReports}",
            _ => String.Empty
            };
    return result;

    ////ShiftWorker? swv = p as ShiftWorker; //as take the value and compare
    //if(p is ShiftWorker swv) // check if p is not null as well as is shiftworker type then declare and assign it to swv
    //    { return $"Employee : {swv.FirstName} {swv.LastName} Started: {swv.StartDate}"; }
    //else if(p is Manager mgrv)
    //    { return $"Manager : {mgrv.FirstName} {mgrv.LastName} Reports: {mgrv.NumberOfDirectReports}"; }
    //return String.Empty;
    }