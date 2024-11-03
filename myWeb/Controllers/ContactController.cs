using Microsoft.AspNetCore.Mvc;

namespace myWeb.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
