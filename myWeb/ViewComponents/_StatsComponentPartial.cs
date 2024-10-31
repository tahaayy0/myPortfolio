using Microsoft.AspNetCore.Mvc;

namespace myWeb.ViewComponents
{
    public class _StatsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
