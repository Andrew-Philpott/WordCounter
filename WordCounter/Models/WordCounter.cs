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
      char[] characters = word.ToLower().ToCharArray();
      foreach (char item in characters)
      {
        switch (item)
        {
          case 'a':
            break;
          case 'b':
            break;
          case 'c':
            break;
          case 'd':
            break;
          case 'e':
            break;
          case 'f':
            break;
          case 'g':
            break;
          case 'h':
            break;
          case 'i':
            break;
          case 'j':
            break;
          case 'k':
            break;
          case 'l':
            break;
          case 'm':
            break;
          case 'n':
            break;
          case 'o':
            break;
          case 'p':
            break;
          case 'q':
            break;
          case 'r':
            break;
          case 's':
            break;
          case 't':
            break;
          case 'u':
            break;
          case 'v':
            break;
          case 'w':
            break;
          case 'x':
            break;
          case 'y':
            break;
          case 'z':
            break;
          default:
            return false;
        }
      }
      return true;
    }
  }
}