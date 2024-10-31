using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.ViewComponents
{
    public class _ExperianceComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {

            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
