using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Razor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RandomNumberController : ControllerBase
	{
		[HttpGet]
		public async Task<ActionResult<int>> GetRandomNumber()
		{
			var task = new Task<int>(() => new Random().Next());
			task.Start();
			await task;
			return task.Result;
		}
	}
}
