using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  public class T9
  {
    /// <summary>
    /// Normalizes a string and removes diacritics.
    /// </summary>
    /// <param name="msg"> written text</param>
    public static string removeDiacritics(String msg)
    {
      //Normalizes unicode characters
      string normalizedText = msg.Normalize(NormalizationForm.FormD);
      StringBuilder encodedNumber = new StringBuilder();
        foreach (char value in normalizedText)
        {
          //Obtains unicode character category
          UnicodeCategory unicodeChar = CharUnicodeInfo.GetUnicodeCategory(value);
          if (unicodeChar != UnicodeCategory.NonSpacingMark)
          {
            encodedNumber.Append(value);
          }          
        }
      return encodedNumber.ToString().Normalize(NormalizationForm.FormC);
    }

    /// <summary>
    /// Encodes a string to the T9 format.
    /// </summary>
    /// <param name="msg">written text</param>
    /// <returns></returns>
    public static string encodeMessage(string msg)
    {
      string result = removeDiacritics(msg);
      result = Regex.Replace(result, "[2-9]", string.Empty);

      result = Regex.Replace(result, "[a]", "2");
      result = Regex.Replace(result, "[b]", "22");
      result = Regex.Replace(result, "[c]", "222");

      result = Regex.Replace(result, "[d]", "3");
      result = Regex.Replace(result, "[e]", "33");
      result = Regex.Replace(result, "[f]", "333");

      result = Regex.Replace(result, "[g]", "4");
      result = Regex.Replace(result, "[h]", "44");
      result = Regex.Replace(result, "[i]", "444");

      result = Regex.Replace(result, "[j]", "5");
      result = Regex.Replace(result, "[k]", "55");
      result = Regex.Replace(result, "[l]", "555");

      result = Regex.Replace(result, "[m]", "6");
      result = Regex.Replace(result, "[n]", "66");
      result = Regex.Replace(result, "[o]", "666");

      result = Regex.Replace(result, "[p]", "7");
      result = Regex.Replace(result, "[q]", "77");
      result = Regex.Replace(result, "[r]", "777");
      result = Regex.Replace(result, "[s]", "7777");

      result = Regex.Replace(result, "[t]", "8");
      result = Regex.Replace(result, "[u]", "88");
      result = Regex.Replace(result, "[v]", "888");

      result = Regex.Replace(result, "[w]", "9");
      result = Regex.Replace(result, "[x]", "99");
      result = Regex.Replace(result, "[y]", "999");
      result = Regex.Replace(result, "[z]", "9999");

      result = Regex.Replace(result, "[^2-9]", " ");

      return result;
    }
  }
}
