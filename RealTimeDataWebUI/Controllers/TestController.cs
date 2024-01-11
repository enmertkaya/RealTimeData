using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
