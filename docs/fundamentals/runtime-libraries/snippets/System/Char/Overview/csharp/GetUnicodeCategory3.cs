//<Snippet6>
using System;
using System.Globalization;

class Example
{
   public static void Main()
   {
      // Define a string with a variety of character categories.
      String s = "The red car drove down the long, narrow, secluded road.";
      // Determine the category of each character.
      foreach (var ch in s)
         Console.WriteLine($"'{ch}': {Char.GetUnicodeCategory(ch)}");
   }
}
// The example displays the following output:
//      'T': UppercaseLetter
//      'h': LowercaseLetter
//      'e': LowercaseLetter
//      ' ': SpaceSeparator
//      'r': LowercaseLetter
//      'e': LowercaseLetter
//      'd': LowercaseLetter
//      ' ': SpaceSeparator
//      'c': LowercaseLetter
//      'a': LowercaseLetter
//      'r': LowercaseLetter
//      ' ': SpaceSeparator
//      'd': LowercaseLetter
//      'r': LowercaseLetter
//      'o': LowercaseLetter
//      'v': LowercaseLetter
//      'e': LowercaseLetter
//      ' ': SpaceSeparator
//      'd': LowercaseLetter
//      'o': LowercaseLetter
//      'w': LowercaseLetter
//      'n': LowercaseLetter
//      ' ': SpaceSeparator
//      't': LowercaseLetter
//      'h': LowercaseLetter
//      'e': LowercaseLetter
//      ' ': SpaceSeparator
//      'l': LowercaseLetter
//      'o': LowercaseLetter
//      'n': LowercaseLetter
//      'g': LowercaseLetter
//      ',': OtherPunctuation
//      ' ': SpaceSeparator
//      'n': LowercaseLetter
//      'a': LowercaseLetter
//      'r': LowercaseLetter
//      'r': LowercaseLetter
//      'o': LowercaseLetter
//      'w': LowercaseLetter
//      ',': OtherPunctuation
//      ' ': SpaceSeparator
//      's': LowercaseLetter
//      'e': LowercaseLetter
//      'c': LowercaseLetter
//      'l': LowercaseLetter
//      'u': LowercaseLetter
//      'd': LowercaseLetter
//      'e': LowercaseLetter
//      'd': LowercaseLetter
//      ' ': SpaceSeparator
//      'r': LowercaseLetter
//      'o': LowercaseLetter
//      'a': LowercaseLetter
//      'd': LowercaseLetter
//      '.': OtherPunctuation
//</Snippet6>
