using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
