using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
