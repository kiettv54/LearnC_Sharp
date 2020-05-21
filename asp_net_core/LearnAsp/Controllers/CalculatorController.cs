using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using LearnAsp.Models;
using System.Text;

namespace LearnAsp.Controllers
{
    public class CalculatorController
    {
        public IActionResult Index(){
            CalculatorModel calculator = new CalculatorModel();
            return View(calculator);
        }
        
        [HttpPost]  
        public ActionResult CalculateSimpleInterestResult(CalculatorModel model)  
        {  
            decimal simpleInterest = (model.Amount*model.Year*model.Rate)/100;  
            StringBuilder sbInterest = new StringBuilder();  
            sbInterest.Append("<b>Amount :</b> " + model.Amount+"<br/>");  
            sbInterest.Append("<b>Rate :</b> " + model.Rate + "<br/>");  
            sbInterest.Append("<b>Time(year) :</b> " + model.Year + "<br/>");  
            sbInterest.Append("<b>Interest :</b> " + simpleInterest);  
            return Content(sbInterest.ToString());  
        }  
    }
}