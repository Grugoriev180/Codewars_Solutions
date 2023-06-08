// Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters 
// then it should replace the missing second character of the final pair with an underscore ('_').

// my solution

using System.Linq;
public class SplitString
{
  public static string[] Solution(string str)
  {
    if(str.Length % 2 != 0)
      str += "_";
    var splitted = Enumerable.Range(0, str.Length)
                         .GroupBy(x => x / 2)
                         .Select(x => new string(x.Select(y => str[y]).ToArray()))
                         .ToArray();
    return splitted;
  }
}