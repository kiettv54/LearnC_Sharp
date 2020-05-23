using Microsoft.AspNetCore.Mvc;
using MVCLearn.Models;
namespace MVCLearn.Controllers
{
    public class CustomerController:Controller
    {
       public IActionResult Index(){
           //viewdata.Model = new Customer()
           ViewBag.Customer = new Customer();
           //var customer = new Customer();
           //return View(customer);
           return View();
       }
        
    }
}