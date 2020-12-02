using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class T9
  {
    /// <summary>
    /// Decode entered message
    /// </summary>
    /// <param name="msg"> written text</param>
    /// <param name="digits">Dictionary that contains choices in T9 Keyboard</param>
    /// <returns>String that contains decoded message</returns>
    public static StringBuilder decodeMessage(String msg, Dictionary<char, int> digits)
    {
      StringBuilder encodedNumber = new StringBuilder();
      if (!String.IsNullOrEmpty(msg))
      {
        foreach (char value in msg)
        {
          foreach (KeyValuePair<char, int> k in digits)
          {
            if (value == k.Key)
            {
              encodedNumber.Append(k.Value.ToString());
              break;
            }
          }
        }
      }
      return encodedNumber;
    }
  }
}
