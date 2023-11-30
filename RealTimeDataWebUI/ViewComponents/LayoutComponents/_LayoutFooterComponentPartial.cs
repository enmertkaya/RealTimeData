using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
