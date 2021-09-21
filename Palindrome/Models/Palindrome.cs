using System;
using System.Linq;

namespace PalindromeChecker
{
    public class Palindrome
    {
        public void CheckIfPalindrome()
        {
          System.Console.WriteLine("Enter a string:");
          string str = Console.ReadLine();


          string charStr = new String(str.Reverse().ToArray());

          // string charStr = new String(str.ToCharArray().Reverse());
          string revStr = charStr;

          System.Console.WriteLine(revStr);
          if (str == revStr) 
          {
            Console.WriteLine("true");
          } 
          else
          {
            Console.WriteLine("false");
          }
        }


    }

}