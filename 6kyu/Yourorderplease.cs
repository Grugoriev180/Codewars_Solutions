// Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.

// Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).

// If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.

// my solution

using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Order(string words)
  {
    string[] w = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string[] sortedWords = new string[w.Length];
    foreach (string word in w)
    {
        int number = int.Parse(Regex.Match(word, @"\d+").Value);
        sortedWords[number - 1] = word;
    }
    return string.Join(" ", sortedWords);
  }
}