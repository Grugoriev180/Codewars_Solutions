// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

// Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

//my solution 

public static class Kata
{
  public static int Solution(int value)
  {
    var sum = 0;
    for (int i = 1; i < value; i++) 
    {
        if ((i % 3 == 0) || (i % 5 == 0)) 
        {
            sum += i;
        }
    }
    return sum;
  }
}