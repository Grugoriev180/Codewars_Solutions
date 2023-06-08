// You are given an array (which will have a length of at least 3, but could be very large) containing integers. The array is either 
// entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. Write a method that takes 
// the array as an argument and returns this "outlier" N.

//my solution 

using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static int Find(int[] integers)
  {
    var oddList = new List<int>();
    var evenList = new List<int>();

    foreach (var integer in integers)
    {
        if (integer % 2 == 0)
        {
            evenList.Add(integer);
        }
        else
        {
            oddList.Add(integer);
        }
    }

    return oddList.Count == 1 ? oddList[0] : evenList[0];
  }
}