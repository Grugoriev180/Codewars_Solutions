// The bloody photocopier is broken... Just as you were sneaking around the office to print off your favourite binary code!

// Instead of copying the original, it reverses it: '1' becomes '0' and vice versa.

// Given a string of binary, return the version the photocopier gives you as a string.

//my solution 

public class Kata
{
  public static string Broken(string x)
  {
    return x.Replace('0', '-').Replace('1', '0').Replace('-', '1');
  }
}