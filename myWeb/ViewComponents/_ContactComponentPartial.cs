using Microsoft.AspNetCore.Mvc;
using myWeb.DataAccessLayer.Context;

namespace myWeb.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke ()
        {
            ViewBag.contactTitle = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.contactDescription = context.Contacts.Select(x => x.Description).FirstOrDefault();
            ViewBag.contactPhone = context.Contacts.Select(x => x.Phone).FirstOrDefault();
            ViewBag.contactAddress = context.Contacts.Select(x => x.Address).FirstOrDefault();
            ViewBag.contactEmail = context.Contacts.Select(x => x.Email).FirstOrDefault();
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
