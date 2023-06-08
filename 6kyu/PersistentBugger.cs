// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number 
// of times you must multiply the digits in num until you reach a single digit.

// my solution

using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
		int count = 0;
    while(n > 9)
    {
        long product = 1;
        while(n > 0)
        {
            product *= n % 10;
            n /= 10;
        }
        n = product;
        count++;
    }
    return count;
	}
}