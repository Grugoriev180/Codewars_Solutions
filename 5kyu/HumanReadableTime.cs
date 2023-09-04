// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

// HH = hours, padded to 2 digits, range: 00 - 99
// MM = minutes, padded to 2 digits, range: 00 - 59
// SS = seconds, padded to 2 digits, range: 00 - 59
// The maximum time never exceeds 359999 (99:59:59)

// You can find some examples in the test fixtures.

//my solution

using System;
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      int hour = seconds / 3600;
      int minute = seconds % 3600 / 60;
      int second = seconds % 3600 % 60;
      
      return String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second);
        
    }
}