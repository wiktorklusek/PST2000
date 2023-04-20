using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      /* This variable will be used to count the number of times anyone tweets the word persnickety */
      /* Calculates tomorrow's rain likelihood as a number between 0 and 100 */
      // string usefulValue = OldSloppyCode();
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
