// Write a function dirReduc which will take an array of strings and returns an array of strings with the needless directions removed (W<->E or S<->N side by side).

// The Haskell version takes a list of directions with data Direction = North | East | West | South.
// The Clojure version returns nil when the path is reduced to nothing.
// The Rust version takes a slice of enum Direction {North, East, West, South}.

//my solution

using System;
using System.Linq;
using System.Collections.Generic;

public class DirReduction {
  
    public static string[] dirReduc(String[] arr) 
    {
      var opposites = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) 
      {
         { "North", "South" },
         { "South", "North" },
         { "East",  "West"  },
         { "West",  "East"  },
      };
      
      var result = new LinkedList<string>();
      
      foreach (string direction in arr)
        if (!string.Equals(result.Last?.Value, 
                        opposites[direction],
                        StringComparison.OrdinalIgnoreCase))
          result.AddLast(direction);
        else
          result.RemoveLast();
      return result.ToArray();
    }
}