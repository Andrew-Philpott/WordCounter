using System;

namespace WordCounter.Models
{
  public class WordCount
  {
    public static bool WordContainsCharacters(string word)
    {
      if (!string.IsNullOrEmpty(word))
      {
        return true;
      }
      return false;
    }

    public static bool WordContainsOnlyLetterCharacters(string word)
    {
      return false;
    }
  }
}