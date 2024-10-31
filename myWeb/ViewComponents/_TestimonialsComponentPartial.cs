using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.ViewComponents
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
