using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
