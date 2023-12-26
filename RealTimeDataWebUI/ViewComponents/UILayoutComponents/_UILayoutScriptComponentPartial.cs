using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
