// There are five workers : James,John,Robert,Michael and William.They work one by one and on weekends they rest. Order is same as in the description(James works on mondays,John works on tuesdays and so on).You have to create a function 'task' that will take 3 arguments(w, n, c):

// Weekday

// Number of trees that must be sprayed on that day

// Cost of 1 litre liquid that is needed to spray tree,let's say one tree needs 1 litre liquid.

// Let cost of all liquid be x

//my solution 

public class Kata
{
  public static string Task(string w, int n, int c)
  {
    //your code
    int x = n*c;
    string[] name = {"Robert", "James", "William", "John", "Michael"};
    
    if(w == "Wednesday")
      {
        string sent = string.Format("It is {0} today, {1}, you have to work, you must spray {2} trees and you need {3} dollars to buy liquid", w, name[0], n, x);
        return sent;
      }
    else if(w == "Monday")
      {
        string sent = string.Format("It is {0} today, {1}, you have to work, you must spray {2} trees and you need {3} dollars to buy liquid", w, name[1], n, x);
        return sent;
      }
    else if(w == "Friday")
      {
        string sent = string.Format("It is {0} today, {1}, you have to work, you must spray {2} trees and you need {3} dollars to buy liquid", w, name[2], n, x);
        return sent;
      }
    else if(w == "Tuesday")
      {
        string sent = string.Format("It is {0} today, {1}, you have to work, you must spray {2} trees and you need {3} dollars to buy liquid", w, name[3], n, x);
        return sent;
      }
    else if(w == "Thursday")
      {
        string sent = string.Format("It is {0} today, {1}, you have to work, you must spray {2} trees and you need {3} dollars to buy liquid", w, name[4], n, x);
        return sent;  
      }  
    else
      {
        return("It is weekend!");
      }
  }
}