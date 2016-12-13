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

				RepeatCounter counter = new RepeatCounter(_originalWord, _originalSentence);

				int matches = counter.CountRepeats();

				Dictionary<string, object> returnBox = new Dictionary<string, object> ()
				{
					{"matches", matches},
					{"counter", counter}
				};
				return View["result.cshtml", returnBox];
			};

		}
	}
}
