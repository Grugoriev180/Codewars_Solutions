// Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, 
// rearrange the digits to create the highest possible number.

//my solution

using System;
using System.Linq;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    int[] digits = num.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray();
    
    Array.Sort(digits);
    Array.Reverse(digits);
    
    int final = 0;
    for (int i = 0; i < digits.Length; i++)
    {
      final += digits[i] * Convert.ToInt32(Math.Pow(10, digits.Length-i-1));
    }
    return final;
  }
}