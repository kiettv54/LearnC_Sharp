using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace LearnMVC.Controllers
{
   
    public class ActionResultController:Controller
    {
         HttpContext ctx;
        public IActionResult Index()=> View();
        //partiaview:return 1/2 View
        public IActionResult Index(string id)=> PartialView();
        public IActionResult Index(int id){
            if(id == 0)
            {
                return NotFound();
            }
            else
            return Content("Hello ActionResult");
        }

    }
}