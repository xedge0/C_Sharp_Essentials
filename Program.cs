using LinkedIn.Essentials;


ShiftWorker sw = new ShiftWorker() { FirstName = "Ahmed", LastName = "Dewedar" };
sw.DaysAvaliable = ShiftDays.Weekdays;

bool avaliableMondays = sw.DaysAvaliable.HasFlag(ShiftDays.Monday);
Console.WriteLine($"Avaliabe Mondays : {avaliableMondays}");

bool avaliableFridays = (sw.DaysAvaliable & ShiftDays.Friday) == ShiftDays.Friday;
Console.WriteLine($"Avaliable Fridays : {avaliableFridays}");

//var shiftNames = Enum.GetName(typeof(ShiftDays));
//Console.WriteLine(String.Join(',', shiftNames));

var shiftDaysValue = (short[])Enum.GetValues(typeof(ShiftDays));
Console.WriteLine(String.Join(',', shiftDaysValue));


var day = DayOfWeek.Monday;
//Console.WriteLine(day);

var shiftday = ShiftDays.Saturday;
//Console.WriteLine((int)shiftday);
