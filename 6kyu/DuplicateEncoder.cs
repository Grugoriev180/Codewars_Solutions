// The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears
// only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when 
// determining if a character is a duplicate.

//my solution

using System.Text;

public class Kata
{
  public static string DuplicateEncode(string str)
  {
    var word = str.ToLower(); 
    var unique = new StringBuilder();
    for (int i = 0; i < word.Length; i++)
    {
        if (word.LastIndexOf(word[i]) == word.IndexOf(word[i]))
        {
            unique.Append('(');
        }
        else
        {
            unique.Append(')');
        }
    }
    return unique.ToString();
    
  }
}