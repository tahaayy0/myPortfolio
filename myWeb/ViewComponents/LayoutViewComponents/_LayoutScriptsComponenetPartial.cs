using Microsoft.AspNetCore.Mvc;

namespace myWeb.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptsComponenetPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
