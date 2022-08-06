﻿using LinkedIn.Essentials;


ShiftWorker sw = new ShiftWorker() { FirstName = "Ahmed", LastName = "Dewedar" };
sw.DaysAvaliable = ShiftDays.Wednesday;

Console.WriteLine(sw.DaysAvaliable);

var day = DayOfWeek.Monday;
Console.WriteLine(day);

var shiftday = ShiftDays.Saturday;
Console.WriteLine((int)shiftday);
