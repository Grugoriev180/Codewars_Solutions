// Given an array of integers, find the one that appears an odd number of times.

// There will always be only one integer that appears an odd number of times.


//my solution

namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
      for (int i = 0; i < seq.Length; i++) 
      {
            int count = 0;
            for (int j = 0; j < seq.Length; j++)
            {
                if (seq[i] == seq[j])
                {
                  count++;
                }
            }
            if (count % 2 != 0)
            {
                return seq[i];
            }
      }  
      return -1;
      
    }
       
  }
}