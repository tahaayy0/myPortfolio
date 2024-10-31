using Microsoft.AspNetCore.Mvc;

namespace myWeb.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
