using System;
using WordCounter.Models;

namespace WordCounter
{


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Word Counter. This application calculates the number of times a word occurs in a sentence where you provide both the word and the sentence.");
      Console.WriteLine("Restrictions are as follows.");
      Console.WriteLine("Word: String containing only letter characters.");
      Console.WriteLine("Sentence: May only be 1 sentence, with an end of sentence punctuation at the end of the sentence.");
      Console.WriteLine("Enter a word:");
      string wordInput = Console.ReadLine();


    }
  }
}