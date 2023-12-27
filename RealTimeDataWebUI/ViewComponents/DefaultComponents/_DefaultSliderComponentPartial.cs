using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
