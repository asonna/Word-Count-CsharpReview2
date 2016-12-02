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

		}
	}
}
