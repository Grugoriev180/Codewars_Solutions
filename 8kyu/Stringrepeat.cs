// Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.

//my solution 

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      string m = "";
      for(int i = 0; i < n; i++)
      {
        m += s;
      }
      return m;
    }
  }
}