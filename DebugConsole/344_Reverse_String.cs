using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a function that takes a string as input and returns the string reversed.

//Example:
//Given s = "hello", return "olleh".

namespace DebugConsole
{
    public class _344_Reverse_String
    {
        public string ReverseString(string s)
        {
            var length = s.Length;

            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = s[length - 1 - i];
            }

            return new string(result);
        }
    }
}
