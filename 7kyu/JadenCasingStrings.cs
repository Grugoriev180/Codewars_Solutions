// Example:

// Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
// Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"

//my solution

using System;
using System.Globalization;

public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower());
  }
}
