using System.Collections.Generic;
using System;
using System.Linq;

namespace TheWordCount.Objects
{
	public class RepeatCounter
	{
		private string _originalWord;
		private string _originalSentence;
		// private int _wordCount = 0;

		public RepeatCounter(string word, string sentence)
		{
			_originalWord = word;
			_originalSentence = sentence;
		}

		public string GetWord()
		{
			return _originalWord;
		}

		public string GetSentence()
		{
			return _originalSentence;
		}

		// public int GetCount()
		// {
		// 	return _wordCount;
		// }

		public int CountRepeats(string _originalWord, string _originalSentence)
		{
			int _workCount = 0;
			if (_originalWord == _originalSentence)
			{
				_workCount += 1;
			}
			else
			{
				_workCount += 0;
			}
			return _workCount;
		}
	}
}
