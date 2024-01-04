using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
