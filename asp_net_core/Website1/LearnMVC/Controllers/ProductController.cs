using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LearnMVC.Models;
namespace LearnMVC.Controllers
{
    public class ProductController:Controller
    {
        //using change url,you must create view:Product ,create name is modify.cshtml
        //you can use one of two
        //[ActionName("modify")]
        //[Route("product/modify")]

        //use method [NonAction],it is method special,it use to tick and it mustn't have action method
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(ProductModel model){
            return RedirectToAction("Index","Home");
        }
        //when you get data in database
        [HttpGet]
        public List<ProductModel> getAll(){
            return new List<ProductModel>();
        }
        //parameter id
        //url:product/test if it is Get
        [HttpGet("{id}")]
        public List<ProductModel> getAll(string id){
            return new List<ProductModel>();
        }
        //Post
        //url:product
        [HttpPost()]
        public IActionResult Create(ProductModel product){
            return Ok();
        }
        //Put:update data
        //id =10
        //url:product/10
         [HttpPut("{id}")]
        public IActionResult Update(string id,[FromBody] ProductModel product){
            return Ok();
        }
        //Delete
        //url:product/10
        [HttpDelete()]
         public IActionResult Delete(string id){
            return Ok();
        }
    }
}