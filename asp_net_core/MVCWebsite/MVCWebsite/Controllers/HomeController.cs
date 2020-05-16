using Microsoft.AspNetCore.Mvc;
using MVCWebsite.Models;

namespace MVCWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "Hello from Model";
            return View(model);
        }
    }
}