using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
