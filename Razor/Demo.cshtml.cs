using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo_Razor.Pages
{
	public class DemoModel : PageModel
	{
		public string Header { get; set; }
		public string ImageUrl { get; set; }
		public List<int> Numbers { get; set; }

		public void OnGet(int? id)
		{
			Header = "SE347 ASP.NET Core MVC Demo";
			ImageUrl = "https://pbs.twimg.com/media/FiX76OuaMAEwg4N?format=jpg&name=large";
			Numbers = new() { id ?? 6, 9, 4, 2, 0 };
			ViewData["Title"] = "DEMO PAGE";
		}
	}
}
