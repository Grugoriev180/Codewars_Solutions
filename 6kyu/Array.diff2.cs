// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

//my solution 

using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    b.ToList();
    var c = a.ToList().Select(i => i).ToList();
    c.RemoveAll(i => b.Contains(i));
    return c.ToArray();
  }
}