﻿using LinkedIn.Essentials;
using System.Diagnostics.CodeAnalysis;

string? input = "something|";

Console.WriteLine(PadAndTrim(input, 15, '0'));

//var shiftDay = GetShiftDays(DateTime.Now.DayOfWeek);
var shiftDay = GetShiftDays((DayOfWeek)17);
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
    if(input == null)
        {
        return String.Empty.PadLeft(length, padChar);
        }

    else if(input.Length <= length && input != null)
        {
        switch(padChar)
            {
            case ' ':
            case '|':
                return input.Trim().PadLeft(length, padChar);
            case '0':
            case '9':
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