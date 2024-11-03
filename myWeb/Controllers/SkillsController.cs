using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;
using myWeb.DataAccessLayer.Entities;

namespace myWeb.Controllers
{
	public class SkillsController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult SkillsList()
		{
			var values = context.Skills.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();	
		}

		[HttpPost]	
		public IActionResult CreateSkill(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("SkillsList");
		}

		public IActionResult DeleteSkill(int id)
		{
			var value = context.Skills.Find(id);
			context.Skills.Remove(value);
			context.SaveChanges();
			return RedirectToAction("SkillsList");
		}
		[HttpGet]
		public IActionResult UpdateSkills(int id)
		{
			var value = context.Skills.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSkills(Skill skill)
		{
			context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("SkillsList");

		}
	}
}
