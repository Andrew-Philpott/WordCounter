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
    SentenceContainsEndOfSentencePunctuationAtEndOfSentence_SentenceStringContainsEndOfSentencePunctuationMarkAtEndOfSentenceAfterCallingTrim_True()
    {
      string sentence = "  ?  ";
      bool containsEndOfSentencePunctuationMarkAtEndOfSentence = WordCount.SentenceContainsEndOfSentencePunctuationAtEndOfSentence(sentence);
      Assert.AreEqual(true, containsEndOfSentencePunctuationMarkAtEndOfSentence);
    }

    [TestMethod]
    public void
    SentenceContainsEndOfSentencePunctuationAtEndOfSentence_EmptySentenceStringAferCallingTrimReturnsFalse_False()
    {
      string sentence = "    ";
      bool containsEndOfSentencePunctuationMarkAtEndOfSentence = WordCount.SentenceContainsEndOfSentencePunctuationAtEndOfSentence(sentence);
      Assert.AreEqual(false, containsEndOfSentencePunctuationMarkAtEndOfSentence);
    }

    [TestMethod]
    public void
       SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation_SentenceStringContainsNonLetterBeforeEndOfSentencePunctuationMarkAtEndOfSentence_False()
    {
      string sentence = "Hi there how are you ?";
      bool isLetter = WordCount.SentenceIsProperlyFormattedWithLetterCharacterBeforeEndOfPunctuation(sentence);
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

    [TestMethod]
    public void
       GetNumberOfMatches_ChecksWordAgainstSentenceContainingOneMatchWithPunctuationFollowingTheWord_1()
    {
      string word = "cat";
      string sentence = "A cat.";

      int matchCount = WordCount.GetNumberOfMatches(word, sentence);
      Assert.AreEqual(1, matchCount);
    }

    [TestMethod]
    public void
       GetNumberOfMatches_ChecksWordAgainstSentenceContainingTwoMatchesAndReturnsTwo_2()
    {
      string word = "cat";
      string sentence = "A cat was friends with another cat named dog.";

      int matchCount = WordCount.GetNumberOfMatches(word, sentence);
      Assert.AreEqual(2, matchCount);
    }

  }
}