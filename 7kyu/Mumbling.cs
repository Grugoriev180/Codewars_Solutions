// This time no story, no theory. The examples below show you how to write function accum:

// Examples:
// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.

//my solution

using System;
using System.Linq;

public class Accumul 
{
	public static String Accum(string s) 
  {
    var res = string.Join("-", s.Select((c,i) => Char.ToUpper(c) + new string(Char.ToLower(c),i)));
    return res;
  }
}