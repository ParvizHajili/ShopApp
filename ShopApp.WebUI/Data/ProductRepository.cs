﻿using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,Name="Nokia",Price=50,Description="Nothing",IsApproved=true,ImageUrl="1.jpg"},
                new Product{ProductId=2,Name="Iphone 5",Price=5000,Description="Good",IsApproved=false,ImageUrl="2.jpg"},
                new Product{ProductId=3,Name="Iphone 6",Price=5600,Description="Good",IsApproved=true,ImageUrl="3.jpg"},
                new Product{ProductId=4,Name="Iphone 7",Price=5546,Description="Good",ImageUrl="4.jpg"}
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
