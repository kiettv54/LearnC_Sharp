using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVCLearn.Models;

namespace MVCLearn.Models
{
    public class ProductEditModel
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Rate { get; set; }
       public int Rating { get; set; }
    }
}