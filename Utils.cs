using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public static class Utils
  {
    public static Dictionary<char, int> addDigits(Dictionary<char, int> digits)
    {
      digits.Add('a', 2);
      digits.Add('b', 22);
      digits.Add('c', 222);
      digits.Add('d', 3);
      digits.Add('e', 33);
      digits.Add('f', 333);
      digits.Add('g', 4);
      digits.Add('h', 44);
      digits.Add('i', 444);
      digits.Add('j', 5);
      digits.Add('k', 55);
      digits.Add('l', 555);
      digits.Add('m', 6);
      digits.Add('n', 66);
      digits.Add('o', 666);
      digits.Add('p', 7);
      digits.Add('q', 77);
      digits.Add('r', 777);
      digits.Add('s', 7777);
      digits.Add('t', 8);
      digits.Add('u', 88);
      digits.Add('v', 888);
      digits.Add('w', 9);
      digits.Add('x', 99);
      digits.Add('y', 999);
      digits.Add('z', 9999);
      digits.Add(' ', 0);
      return digits;
    }
  }
}
