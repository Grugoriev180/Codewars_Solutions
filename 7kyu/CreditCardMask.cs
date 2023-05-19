// Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

// Your task is to write a function maskify, which changes all but the last four characters into '#'.

//my solution

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    if(cc.Length > 4)
    {
      string new_string = "";
    
      for (var i = 0; i < cc.Length - 4; i++)
      {
       new_string += "#";
      }
    
      new_string += cc.Substring(cc.Length - 4);
      return new_string;   
    }
    else
    {
      return cc;  
    }
  }
}