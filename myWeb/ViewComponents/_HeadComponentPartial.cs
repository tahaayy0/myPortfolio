﻿using Microsoft.AspNetCore.Mvc;

namespace myWeb.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}