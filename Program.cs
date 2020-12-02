using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare Dictionary to put all existing choice of user on T9 keybord
      Dictionary<char, int> digits = new Dictionary<char, int>();
      // message written
      Console.Write("Veuillez entrer votre message: ");
      string message = Console.ReadLine();
      
      //Fill up dictionarywith digits
      Dictionary<char, int> digitResults = Utils.addDigits(digits);

      //Call the function to decode message
      StringBuilder encodedNumber = T9.decodeMessage(message, digits);

      //launch console to show result
      Console.WriteLine(encodedNumber);
      Console.ReadKey();
    }
  }
}
