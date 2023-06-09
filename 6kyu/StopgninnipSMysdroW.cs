// Write a function that takes in a string of one or more words, and returns the same string, 
// but with all five or more letter words reversed (Just like the name of this Kata). 
// Strings passed in will consist of only letters and spaces. Spaces will be included 
// only when more than one word is present.

//my solution

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string spinWordSentence = "";
    string[] words = sentence.Split(' ');

    for(int i = 0; i < words.Length; i++)
    {
      if (spinWordSentence != "")
        spinWordSentence += ' ';
      if(words[i].Length >= 5)
      {
        char[] arr = words[i].ToCharArray();
        Array.Reverse(arr);
        spinWordSentence += new string(arr);
      }
      else
      {
        spinWordSentence += words[i];
      }
    }
    return spinWordSentence;
  }
}