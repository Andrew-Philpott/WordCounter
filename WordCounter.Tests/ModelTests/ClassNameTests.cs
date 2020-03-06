using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {

    [TestMethod]
    public void WordContainsCharacters_WordStringContainsCharactersReturnsTrue_True()
    {
      string word = "hello";
      bool containsCharacters = WordCount.WordContainsCharacters(word);
      Assert.AreEqual(true, containsCharacters);
    }

    [TestMethod]
    public void WordContainsOnlyLetterCharacters_WordStringContainingOnlyLetterCharactersReturnsTrue_True()
    {
      string word = "hello";
      bool containsCharacters = WordCount.WordContainsOnlyLetterCharacters(word);
      Assert.AreEqual(true, containsCharacters);
    }

    [TestMethod]
    public void SentenceContainsOnlyOneEndOfSentencePunctuationMark_SentenceStringContainsOnlyOneEndOfSentencePunctuationMarkReturnsTrue_True()
    {
      string word = "Hi there how are you?";
      bool containsOneEndOfSentencePunctuationMark = WordCount.SentenceContainsOnlyOneEndOfSentencePunctuationMark(word);
      Assert.AreEqual(true, containsOneEndOfSentencePunctuationMark);
    }

  }
}