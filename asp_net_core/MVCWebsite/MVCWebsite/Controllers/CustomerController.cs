using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebsite.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        [Route("vip")]
        public string Vip()
        {
            return "Customer vip";
        }
        [Route("")]
        [Route("normal")]
        public string Normal()
        {
            return "Customer normal";
        }
    }
}