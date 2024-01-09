using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.Controllers
{
    public class BookATableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
