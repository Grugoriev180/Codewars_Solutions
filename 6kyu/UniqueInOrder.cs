// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the 
// same value next to each other and preserving the original order of elements.

// my solution

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    var list = new List<T>();
    foreach (var item in iterable) 
      if (!item.Equals(list.LastOrDefault())) 
        list.Add(item);
    return list;
  }
}