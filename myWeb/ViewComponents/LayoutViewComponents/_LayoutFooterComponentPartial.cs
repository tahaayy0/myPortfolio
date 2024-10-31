using Microsoft.AspNetCore.Mvc;

namespace myWeb.ViewComponents.LayoutViewComponents
{
	public class _LayoutFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
