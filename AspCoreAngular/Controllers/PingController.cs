using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspCoreAngular.Controllers
{
	[Route("api/[controller]")]
	public class PingController : Controller
	{
		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "Hello", "World" };
		}
	}
}
