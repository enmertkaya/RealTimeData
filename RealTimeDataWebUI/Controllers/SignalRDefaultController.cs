using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
