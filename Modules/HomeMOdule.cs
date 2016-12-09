using Microsoft.CSharp.RuntimeBinder;
using System;
using System.IO;
using Nancy;
using System.Collections.Generic;
using TheWordCount.Objects;

namespace TheWordCount
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};

			Post["/result"] = _ =>
			{
				string _originalWord = Request.Form["originalWord"];
				string _originalSentence = Request.Form["originalSentence"];
				int _wordCount = 0;

				RepeatCounter Result = new RepeatCounter(_originalWord, _originalSentence);

				return View["result.cshtml", Result.CountRepeats()];
			};

		}
	}
}
