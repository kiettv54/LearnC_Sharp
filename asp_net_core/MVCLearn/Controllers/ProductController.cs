using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
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
       
       #region Pass data from Controller to View
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        public IActionResult Index2(){
           return View();
        }
        [HttpPost]
        public IActionResult Create( ProductEditModel models){
            string message = string.Empty;
            if(ModelState.IsValid)
            {
                /* you can try it if you want 
                if(models.Name == ""){
                    ModelState.AddModelError("","This product name was existed");
                    return View(models);
                } */
                DateTime? dateTime = models.CreatedDate;
               string dt = dateTime?.ToString("dd/MM/yyyy");
                message = "Product:" + models.Name + ", Rate:"+ models.Rate + ", Rating:"+models.Rating +", CreatedDate:" +dt;// models.CreatedDate ;//+", Email:"+models.Email;
            }
            else
            {
                return View(models);
               // message = "Falled to create the product. Please try again";
            }
            return Content(message);
        }
       #endregion
       #region Model binding machenism
        [HttpPost]
        public IActionResult NoModelBinding(){
            ProductEditModel model = new ProductEditModel();
            string message = "";
            model.Name = Request.Form["Name"].ToString();
            model.Rate = Convert.ToDecimal(Request.Form["Rate"].ToString());
            model.Rating = Convert.ToInt32(Request.Form["Rating"].ToString());
            message = "Product :"+model.Name + ", Rate:" + model.Rate + ", Rating:"+ model.Rating;
            return View(message);
        }
        [HttpGet]
        public IActionResult FormAndQuery(){
            
            return View();
        }
        [HttpPost]
         public IActionResult FormAndQuery([FromQuery]string name, ProductEditModel model){
            string message = string.Empty;
            if(ModelState.IsValid){
                message = "Query string " + name +" product " + model.Name + " Rate " + model.Rate +" Rating " + model.Rating;
            }
            else
            {
                message = "Falled to create the product. Please try again!";
            }
            return Content(message);
        }
       #endregion

    }
}