using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOfferComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
