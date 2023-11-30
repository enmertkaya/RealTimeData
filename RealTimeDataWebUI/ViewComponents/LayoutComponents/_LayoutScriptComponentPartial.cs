using Microsoft.AspNetCore.Mvc;

namespace RealTimeDataWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
