using Xunit;
using System.Collections.Generic;
using System;
using TheWordCount.Objects;

namespace TheWordCount.Objects
{
  public class WordCountTest
  {
    [Fact]
    // Check a word again itself and validate a match
    public void CountRepeats_AgainstItself_1()
    {
      RepeatCounter newWord = new RepeatCounter("WORD", "WORD");
      Assert.Equal(1, newWord.CountRepeats("WORD", "WORD"));
    }

    [Fact]
    // Check a word again string of words with a single match and still return a count of 1
    public void CountRepeats_AgainstStringOfWordWithSingleMatch_1()
    {
      RepeatCounter newWord = new RepeatCounter("LIFE", "LIFE IS NOT EASY");
      Assert.Equal(1, newWord.CountRepeats("LIFE", "LIFE IS NOT EASY"));
    }

    [Fact]
    // Check a word again string of words with multiple match and return number of matches
    public void CountRepeats_AgainstStringOfWordWithMultipleMatch_3()
    {
      RepeatCounter newWord = new RepeatCounter("DOG", "A DOG OWNER TOOK HIS DOG INTO A DOG STORE");
      Assert.Equal(3, newWord.CountRepeats("DOG", "A DOG OWNER TOOK HIS DOG INTO A DOG STORE"));
    }

    [Fact]
    // Check a word again string of words with word appearing as partial in other words
    public void CountRepeats_AgainstStringOfWordWithPartialOrContainedMatch_1()
    {
      RepeatCounter newWord = new RepeatCounter("CAT", "A CAT WAS CATCHING A NAP AT THE CATHEDRAL");
      Assert.Equal(1, newWord.CountRepeats("CAT", "A CAT WAS CATCHING A NAP AT THE CATHEDRAL"));
    }

    [Fact]
    // Check a word again string of words with no match
    public void CountRepeats_AgainstStringOfWordWithNoMatch_0()
    {
      RepeatCounter newWord = new RepeatCounter("REALLY", "I WILL ACE THIS REVIEW");
      Assert.Equal(0, newWord.CountRepeats("REALLY", "I WILL ACE THIS REVIEW"));
    }

    [Fact]
    public void CountRepeats_AgainstStringOfWordWithMixedCaseMultipleMatch_3()
    {
      RepeatCounter newWord = new RepeatCounter("DOG", "Dog owners take theirs dog into a Dog Store");
      Assert.Equal(3, newWord.CountRepeats("DOG", "Dog owners take theirs dog into a Dog Store"));
    }
  }
}
