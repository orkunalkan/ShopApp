using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Component
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //if (RouteData.Values["action"].ToString() == "List")
            //{
            //    ViewBag.SelectedCategory = RouteData?.Values["id"];
            //}
            return View();
        }
    }
}
