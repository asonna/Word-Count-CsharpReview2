using System.Collections.Generic;
using System;
using System.Linq;

namespace TheWordCount.Objects
{
	public class RepeatCounter
	{
		private string _originalWord;
		private string _originalSentence;
		private int _wordCount = 0;

		public RepeatCounter(string word, string sentence)
		{
			_originalWord = word;
			_originalSentence = sentence;
			_wordCount = 0;
		}

		public string GetWord()
		{
			return _originalWord;
		}

		public string GetSentence()
		{
			return _originalSentence;
		}

		public int _GetWordCount()
		{
			return _wordCount;
		}


		public int CountRepeats()
		{
			List<string> matchList = new List<string>(_originalSentence.Split(' '));
			int _wordCount = 0;

			foreach (string word in matchList)
			{
				if (_originalWord.ToLower() == word.ToLower())
				{
					_wordCount += 1;
				}
			}
			return _wordCount;
		}
	}
}
