using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCTest.Models;

namespace MVCTest.ViewComponents
{
    public class ProductViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Skittles",
                    Category = "Candy"

                },
                new Product()
                {
                    Id = 2,
                    Name = "Albeni",
                    Category = "Candy"
                }
            };
            return View(products);
        }
        
    }
}