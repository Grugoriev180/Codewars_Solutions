// Complete the solution so that it reverses the string passed into it.

//my solution

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);;
  }
}