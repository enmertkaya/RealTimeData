using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
