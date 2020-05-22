using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLearn.Models;

namespace MVCLearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       /*  public IActionResult Index(int id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Home ,id :"+id;
           
            return View(model);
        } */
        public IActionResult Index(){
            //using Viewdata
             ViewData["Product"] = new ProductModel(){Id = 1,Name = "Nam", Available =true, Price = 10000,PromotionPrice = 8000};
             //using ViewBag
             ViewBag.Product = new ProductModel(){Id = 1,Name = "Nam", Available =true, Price = 10000,PromotionPrice = 8000};
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
