using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
	public class QRCodeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
