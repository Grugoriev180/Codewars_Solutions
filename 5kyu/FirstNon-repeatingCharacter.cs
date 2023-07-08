// Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

// For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

// As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.

// If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.


//my solution

using System;
using System.Linq;
public class Kata
{
  public static string FirstNonRepeatingLetter(string s)
  {
    foreach (char c in s)
    {
        int count = s.ToLower().Count(ch => ch == Char.ToLower(c));
        if (count == 1)
            return c.ToString();
    }
    return "";
  }
}