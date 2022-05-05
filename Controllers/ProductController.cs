using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class Product2
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Owner { get; set; }

    }
    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product); 
            }
            
            
            return View();
        }

        public IActionResult GetProduct(string a, string b, string id)
        {
            return View();
        }
    }
}
