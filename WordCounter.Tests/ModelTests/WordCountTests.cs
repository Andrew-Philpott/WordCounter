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
      string sentence = "Hi there how are you?";
      bool containsOneEndOfSentencePunctuationMark = WordCount.SentenceContainsOnlyOneEndOfSentencePunctuationMark(sentence);
      Assert.AreEqual(true, containsOneEndOfSentencePunctuationMark);
    }

    [TestMethod]
    public void SentenceContainsOnlyOneEndOfSentencePunctuationMark_SentenceStringContainsOnlyTwoEndOfSentencePunctuationMarkReturnsFalse_False()
    {
      string sentence = "Hi there! Lets get started.";
      bool containsOneEndOfSentencePunctuationMark = WordCount.SentenceContainsOnlyOneEndOfSentencePunctuationMark(sentence);
      Assert.AreEqual(false, containsOneEndOfSentencePunctuationMark);
    }

    [TestMethod]
    public void SentenceContainsEndOfSentencePunctuationAtEndOfSentence_SentenceStringContainsEndOfSentencePunctuationMarkAtEndOfSentenceReturnsTrue_True()
    {
      string sentence = "Hi there how are you?";
      bool containsEndOfSentencePunctuationMarkAtEndOfSentence = WordCount.SentenceContainsEndOfSentencePunctuationAtEndOfSentence(sentence);
      Assert.AreEqual(true, containsEndOfSentencePunctuationMarkAtEndOfSentence);
    }
    [TestMethod]
    public void
        SentenceContainsEndOfSentencePunctuationAtEndOfSentence_SentenceStringContainsEndOfSentencePunctuationMarkAtEndOfSentenceAfterCallingTrimReturnsTrue_True()
    {
      string sentence = "  Hi there how are you?  ";
      bool containsEndOfSentencePunctuationMarkAtEndOfSentence = WordCount.SentenceContainsEndOfSentencePunctuationAtEndOfSentence(sentence);
      Assert.AreEqual(true, containsEndOfSentencePunctuationMarkAtEndOfSentence);
    }

    [TestMethod]
    public void
        SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation_SentenceStringContainsLetterBeforeEndOfSentencePunctuationMarkAtEndOfSentence_True()
    {
      string sentence = "Hi there how are you?";
      char[] characters = sentence.ToCharArray();
      char secondToLastCharacter = characters[characters.Length - 2];
      bool isLetter = WordCount.SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation(secondToLastCharacter);
      Assert.AreEqual(true, isLetter);
    }

    [TestMethod]
    public void
       SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation_SentenceStringContainsNonLetterBeforeEndOfSentencePunctuationMarkAtEndOfSentence_False()
    {
      string sentence = "Hi there how are you ?";
      char[] characters = sentence.ToCharArray();
      char secondToLastCharacter = characters[characters.Length - 2];
      bool isLetter = WordCount.SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation(secondToLastCharacter);
      Assert.AreEqual(false, isLetter);
    }

    [TestMethod]
    public void
       GetNumberOfMatches_ChecksWordAgainstSentenceContainingNoMatchesReturnsZero_0()
    {
      string word = "cat";
      string sentence = "Only a dog in this sentence.";

      int matchCount = WordCount.GetNumberOfMatches(word, sentence);
      Assert.AreEqual(0, matchCount);
    }

    [TestMethod]
    public void
       GetNumberOfMatches_ChecksWordAgainstSentenceContainingOneMatchThatIsSurroundedByWhiteSpaceReturnsOne_1()
    {
      string word = "cat";
      string sentence = "Only a cat in this sentence.";

      int matchCount = WordCount.GetNumberOfMatches(word, sentence);
      Assert.AreEqual(1, matchCount);
    }

    [TestMethod]
    public void
       GetNumberOfMatches_ChecksWordAgainstSentenceContainingOneMatchWithDifferentCasing_1()
    {
      string word = "cat";
      string sentence = "Only a Cat in this sentence.";

      int matchCount = WordCount.GetNumberOfMatches(word, sentence);
      Assert.AreEqual(1, matchCount);
    }
  }
}