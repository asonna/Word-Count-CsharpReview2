using Xunit;
using System.Collections.Generic;
using System;

namespace TheWordCount.Objects
{
  public class WordCountTest
  {
    [Fact]
    public void CountRepeats_ForSingleWordAgainstItself_1()
    {
      RepeatCounter newWord = new RepeatCounter("WORD", "WORD");
      Assert.Equal(1, newWord.CountRepeats("WORD", "WORD"));
    }

    [Fact]
    public void CountRepeats_ForSingleWordAgainstStringOfWordIncludingItselfOnce_1()
    {
      RepeatCounter newWord = new RepeatCounter("LIFE IS NOT EASY", "LIFE");
      Assert.Equal(1, newWord.CountRepeats("LIFE IS NOT EASY", "LIFE"));
    }
  }
}
