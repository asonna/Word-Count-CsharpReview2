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

		public int CountRepeats(string _originalWord, string _originalSentence)
		{
			List<string> matchlist = new List<string> (_originalSentence.Split(' '));
			int _workCount = 0;

			foreach (string word in matchlist)
			{
				if (_originalWord == word)
				{
					_workCount += 1;
				}

			}
			return _workCount;
		}
	}
}
