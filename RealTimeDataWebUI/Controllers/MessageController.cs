using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
