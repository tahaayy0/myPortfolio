using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;
using myWeb.DataAccessLayer.Entities;

namespace myWeb.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult AboutList()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var value = context.Abouts.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateAbout(About about)
		{
			context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("AboutList");

		}
	}
}
