using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;
using myWeb.DataAccessLayer.Entities;

namespace myWeb.Controllers
{
	public class FeatureController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult FeatureList()
		{
			var values = context.Features.ToList();
			return View(values);
		}

		[HttpGet]

		public IActionResult UpdateFeature(int id)
		{
			var result = context.Features.Find(id);
			return View(result);
		}

		[HttpPost]

		public IActionResult UpdateFeature(Feature feature)
		{
			context.Features.Update(feature);
			context.SaveChanges();
			return RedirectToAction("FeatureList");
		}
	}
}
