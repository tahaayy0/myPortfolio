using Microsoft.AspNetCore.Mvc;

namespace myWeb.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
