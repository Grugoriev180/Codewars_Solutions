// You are going to be given an array of integers. Your job is to take that array and find an index N where the sum of the integers to 
// the left of N is equal to the sum of the integers to the right of N. If there is no index that would make this happen, return -1.

// my solution

using System.Linq;
public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int leftSum = 0;
    int rightSum = arr.Sum();

    for (int i = 0; i < arr.Length; i++)
    {
        rightSum -= arr[i];

        if (leftSum == rightSum)
        {
            return i;
        }
        leftSum += arr[i];
    }
    return -1;
  }
}