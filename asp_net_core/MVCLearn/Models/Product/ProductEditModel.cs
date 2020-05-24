using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVCLearn.Models;
using System;
namespace MVCLearn.Models
{
    public class ProductEditModel
    {
       public int Id { get; set; }
       [Required(ErrorMessage="Name is required.")]
       [StringLength(maximumLength:50,MinimumLength = 5,ErrorMessage ="Length must between 5 to 50")]
       public string Name { get; set; }
       public decimal? Rate { get; set; }
       public int? Rating { get; set; }   
       public DateTime? CreatedDate { get; set; }
       /* [EmailAddress]
       public string Email { get; set; } */
    }
}