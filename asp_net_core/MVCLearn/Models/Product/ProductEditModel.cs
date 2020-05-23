using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MVCLearn.Models;

namespace MVCLearn.Models
{
    public class ProductEditModel
    {
        public int ProductId { get; set; }
    
        [Required(ErrorMessage = "Product Name is Required")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
    
        public decimal Price { get; set; }
        public int Rating { get; set; }
    
        public List<Brand> Brands { get; set; }
        public List<Supplier> Suppliers { get; set; }
    
        public int BrandID { get; set; }
        public int SupplierID { get; set; }
    }
}