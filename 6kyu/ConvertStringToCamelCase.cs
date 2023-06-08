// Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output 
// should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). 
// The next words should be always capitalized.

// my solution

using System;
using System.Linq;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    return string.Join("", str.Split('-','_').Select((item, index) => index != 0 ? item.Substring(0, 1).ToUpper() + item.Substring(1) : item));
  }
}