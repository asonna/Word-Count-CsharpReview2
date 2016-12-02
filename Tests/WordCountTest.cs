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


  }
}
