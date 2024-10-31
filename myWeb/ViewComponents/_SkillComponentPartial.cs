using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
