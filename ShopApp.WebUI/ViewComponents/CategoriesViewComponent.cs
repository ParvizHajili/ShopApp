﻿using Microsoft.AspNetCore.Mvc;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //if(RouteData.Values["action"].ToString()=="list")
            //ViewBag.SelectedCategory=RouteData?.Values["id"];
            //return View(CategoryRepository.Categories);
            return View();
        }
    }
}
