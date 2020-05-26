using DISample.Services.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Services
{
    public class ProductService:IProductService
    {
       public  List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel(){Id=1,Name ="television"},
                new ProductViewModel(){Id=2,Name ="Iphone"},
                new ProductViewModel(){Id=3,Name ="Laptop"},
                new ProductViewModel(){Id=4,Name ="PC"}
            };
        }
    }
}
