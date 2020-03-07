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


    public static bool SentenceContainsOnlyOneEndOfSentencePunctuationMark(string sentence)
    {
      char[] characters = sentence.ToCharArray();
      int endOfSentencePunctuationCount = 0;
      foreach (char item in characters)
      {
        switch (item)
        {
          case '.':
            endOfSentencePunctuationCount++;
            break;
          case '!':
            endOfSentencePunctuationCount++;
            break;
          case '?':
            endOfSentencePunctuationCount++;
            break;
        }
        if (endOfSentencePunctuationCount >= 2)
        {
          return false;
        }
      }
      if (endOfSentencePunctuationCount == 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool SentenceContainsEndOfSentencePunctuationAtEndOfSentence(string sentence)
    {
      string trimmedSentence = sentence.Trim();
      if (string.IsNullOrEmpty(trimmedSentence))
      {
        return false;
      }
      else
      {
        char lastCharacterInSentence = trimmedSentence[trimmedSentence.Length - 1];
        if (lastCharacterInSentence == '?' || lastCharacterInSentence == '!' || lastCharacterInSentence == '.')
        {
          return true;
        }
        else
        {
          return false;
        }
      }

    }

    public static bool SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation(string characterBeforeEndOfSentence)
    {
      char secondToLastCharacter = characterBeforeEndOfSentence[characterBeforeEndOfSentence.Length - 1];
      switch (secondToLastCharacter)
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
      return true;
    }

    public static int GetNumberOfMatches(string word, string sentence)
    {
      int numberOfMatches = 0;
      string[] sentenceWords = sentence.Split(" ");
      foreach (string sentenceWord in sentenceWords)
      {
        string lowerCaseSentenceWord = sentenceWord.ToLower();

        if (lowerCaseSentenceWord.Length == word.Length)
        {
          if (lowerCaseSentenceWord == word)
          {
            numberOfMatches++;
          }
        }
        else if (lowerCaseSentenceWord.Length == (word.Length + 1))
        {
          bool isPunctuation = false;
          char lastPositionOfLowerCaseWord = lowerCaseSentenceWord[lowerCaseSentenceWord.Length - 1];

          switch (lastPositionOfLowerCaseWord)
          {
            case '.':
            case '?':
            case '!':
            case '\'':
            case '\"':
              isPunctuation = true;
              break;
            default:
              break;
          }
          if (isPunctuation && (word == lowerCaseSentenceWord.Substring(0, lowerCaseSentenceWord.Length - 1)))
          {
            numberOfMatches++;
          }
        }
      }
      return numberOfMatches;
    }
  }
}