using Demo_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_MVC.Controllers
{
	public class DemoController : Controller
	{
		//[Route("demo/mvc/aspnet/{id?}")]
		public IActionResult Index()
		{
			var model = new DemoModel()
			{
				Header = "SE347 ASP.NET Core MVC Demo",
				ImageUrl = "https://pbs.twimg.com/media/FiX76OuaMAEwg4N?format=jpg&name=large",
				Numbers = new() { 6, 9, 4, 2, 0 }
			};

			//ViewData["Title"] = "DEMO PAGE";

			return View(model);
		}







		//public IActionResult Index(int? id)
		//{
		//	var model = new DemoModel()
		//	{
		//		Header = "SE347 ASP.NET Core MVC Demo",
		//		ImageUrl = "https://pbs.twimg.com/media/FiX76OuaMAEwg4N?format=jpg&name=large",
		//		Numbers = new() { id ?? 6, 9, 4, 2, 0 }
		//	};

		//ViewData["Title"] = "DEMO PAGE";

		//	return View(model);
		//}
	}
}
