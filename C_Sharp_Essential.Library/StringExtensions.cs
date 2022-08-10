using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Essential.Library.Extensions;

public static class StringExtensions
    {
    public static string Right(this string input, int numChars)
        {
        if(string.IsNullOrEmpty(input))
            { return string.Empty; }

        return input.Substring(input.Length - numChars);
        }
    }
