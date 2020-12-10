using System;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      // message written
      Console.Write("Veuillez entrer votre message: ");
      string message = Console.ReadLine();

      //Call the function to decode message
      string encodedNumber = T9.encodeMessage(message);

      //launch console to show result
      Console.WriteLine(encodedNumber);
      Console.ReadKey();
    }
  }
}
