// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

//my solution 

using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(n => !b.Contains(n)).ToArray();
  }
}