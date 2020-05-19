using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebsite.Controllers
{
    public class PostController : Controller
    {
        public IActionResult PostById(int id)
        {
            return View();
        }
        public IActionResult PostByPastName(string id)
        {
            return View();
        }

    }
}