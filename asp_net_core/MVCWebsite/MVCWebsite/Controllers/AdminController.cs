using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebsite.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "Hello Admin controller";
        }
    }
}