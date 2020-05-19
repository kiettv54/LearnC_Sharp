using Microsoft.AspNetCore.Mvc;
using MVCWebsite.Models;

namespace MVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index(int id)//year
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Home, id=" + id;//year
        //    return View(model);
        //}
        //public IActionResult Index(int year)//year
        //{
        //    var model = new IndexModel();
        //    model.Message = "Hello from Home, id=" + year;//year
        //    return View(model);
        //}
        public IActionResult Index(string id)
        {
            var model = new IndexModel();
            model.Message = "Hello from Home, id=" + id;
            return View(model);
        }
    }
}