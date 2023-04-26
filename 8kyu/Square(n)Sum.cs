// Complete the square sum function so that it squares each number passed into it and then sums the results together.

//my solution

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int res = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        res += numbers[i]*numbers[i];
    }
    return res;
  }
}
