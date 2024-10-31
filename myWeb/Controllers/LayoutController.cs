using Microsoft.AspNetCore.Mvc;

namespace myWeb.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
