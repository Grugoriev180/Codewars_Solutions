// Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary
// representation of that number. You can guarantee that input is non-negative.

//my solution

using System;
using System.Linq;

public class Kata
{
  public static int CountBits(int n)
  {
    string binary = Convert.ToString(n, 2);
    return binary.Count(c => c == '1');
  }
}