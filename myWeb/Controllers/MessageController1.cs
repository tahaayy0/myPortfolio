using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.Controllers
{
	public class MessageController1 : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();	
		public IActionResult Index()
		{
			return View();
		}
	}
}
