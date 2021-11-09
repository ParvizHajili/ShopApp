﻿using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entity;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List(string category)
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GetProductsByCategory(category)
            };

            return View(productViewModel);
        }

        public IActionResult Details( int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id);

            if(product==null)
            {
                return NotFound();
            }

            return View(new ProductDetailModel
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()

            });
        }
    }
}