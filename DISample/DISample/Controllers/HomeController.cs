using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DISample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IProductService productService;
        //public HomeController(IProductService _productService)
        //{
        //    productService = _productService;
        //}
        public IActionResult Index([FromServices] IProductService productService)
        {
            var products = productService.GetAll();
            return View(products);
        }
    }
}
