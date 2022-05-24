using Microsoft.AspNetCore.Mvc;
using PraktikaImport.Models;
using System.Collections.Generic;

namespace PraktikaImport.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Image = "A-Black-Racer-Snake.webp",
                    Name = "Black Mamba",
                    Info = "Lorem Lorem",
                    Price = 10000
                },
                new Product
                {
                    Id = 2,
                    Image = "Jaguar.jpg",
                    Name = "Panther",
                    Info = "Lorem Lorem",
                    Price = 20000 
                },
                
                new Product
                {
                    Id = 2,
                    Image = "bald-eagle-closeup_4x3.webp",
                    Name = "Eagle",
                    Info = "Lorem Lorem",
                    Price = 5000
                }
                
            };
            ViewBag.Products = products;
            ViewData["Products"] = products;
            return View(products);

        }
    }
}
