using Nancy;
using System.Collections.Generic;
using TheWordCount.Objects;

namespace TheWordCount.Objects
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};

			// Get["/result"] = _ =>
			// {
			// 	string word = Request.Form["originalWord"];
			// 	string sentence = Request.Form["originalSentence"];
			//
			// 	int Result = RepeatCounter.CountRepeats(word, sentence);
			//
			// 	return View["result.cshtml", Result];
			// };

		}
	}
}
