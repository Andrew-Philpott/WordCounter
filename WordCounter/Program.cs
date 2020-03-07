using System;
using WordCounter.Models;

namespace WordCounter
{


  public class Program
  {
    public static bool VerifyWord(string word)
    {
      if (!(WordCount.WordContainsCharacters(word)))
      {
        Console.WriteLine("Word must contain at least one letter.");
        return false;
      }
      if (!(WordCount.WordContainsOnlyLetterCharacters(word)))
      {
        Console.WriteLine("Word must contain only letter characters.");
        return false;
      }
      return true;
    }

    public static bool VerifySentence(string sentence)
    {
      string trimmedSentence = sentence.Trim();

      bool isOneSentence = WordCount.SentenceContainsOnlyOneEndOfSentencePunctuationMark(trimmedSentence);


      bool sentenceContainsEndOfSentencePunctuation = WordCount.SentenceContainsEndOfSentencePunctuationAtEndOfSentence(trimmedSentence);

      bool sentenceFormattedCorrectly = WordCount.SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation(trimmedSentence);
      if (!isOneSentence)
      {
        Console.WriteLine("Only one sentence may be entered.");
        return false;
      }
      else if (!sentenceContainsEndOfSentencePunctuation)
      {
        Console.WriteLine("Please include either a \".\", \"?\", or \"!\" at the end of the sentence.");
        return false;
      }
      else if (!sentenceFormattedCorrectly)
      {
        Console.WriteLine("Please finish your sentence with a word followed by either a \".\", \"?\", or \"!\"");
        return false;
      }
      else
      {
        return true;
      }
    }
    public static void Main()
    {
      Console.WriteLine("Welcome to Word Counter. This application calculates the number of times a word occurs in a sentence where you provide both the word and the sentence.");
      Console.WriteLine("Restrictions are as follows.");
      Console.WriteLine("Word: String containing only letter characters.");
      Console.WriteLine("Sentence: May only be 1 sentence, with an end of sentence punctuation at the end of the sentence.");
      Console.WriteLine("Enter a word:");
      string wordInput = Console.ReadLine();
      bool validWord = VerifyWord(wordInput);
      while (!validWord)
      {
        Console.WriteLine("Enter a word:");
        wordInput = Console.ReadLine();
        VerifyWord(wordInput);
      }
      Console.WriteLine("Enter a sentence:");
      string sentenceInput = Console.ReadLine();
      bool validSentence = VerifySentence(sentenceInput);
      while (!validSentence)
      {
        Console.WriteLine("Enter a sentence:");
        sentenceInput = Console.ReadLine();
        VerifySentence(sentenceInput);
      }
    }
  }
}