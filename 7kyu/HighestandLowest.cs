//In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

//my solution

using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var l = numbers.Split().Select(int.Parse);
    return l.Max() + " " + l.Min();
  }
}