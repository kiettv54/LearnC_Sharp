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
    public class ProductController: Controller
    {
       public List<ProductModel> products= new List<ProductModel>(){

           new ProductModel(){Id = 1,Name = "Nam", Available =true, Price = 10000,PromotionPrice = 8000},
           new ProductModel(){Id = 2,Name = "NamCam", Available =false, Price = 15000,PromotionPrice = 10000}
       }; 
        public IActionResult Index(){
            
            return View(products);
        }
    }
}