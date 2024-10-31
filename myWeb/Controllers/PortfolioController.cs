using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;
using myWeb.DataAccessLayer.Entities;

namespace myWeb.Controllers
{
	public class PortfolioController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult PortfolioList()
		{
			var values = context.Portfolios.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreatePortfolio()
		{

			return View();
		}
		[HttpPost]
		public IActionResult CreatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Add(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}

		public IActionResult DeletePortfolio(int id)
		{
			var values = context.Portfolios.Find(id);
			context.Portfolios.Remove(values);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");
		}

		[HttpGet]
		public IActionResult UpdatePortfolio(int id)
		{
			var value = context.Portfolios.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdatePortfolio(Portfolio portfolio)
		{
			context.Portfolios.Update(portfolio);
			context.SaveChanges();
			return RedirectToAction("PortfolioList");

		}
	}
}
