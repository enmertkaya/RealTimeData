using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
