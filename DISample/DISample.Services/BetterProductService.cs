using DISample.Services.DTos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Services
{
    public class BetterProductService:IProductService
    {
       public  List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>()
            {
                new ProductViewModel(){Id=1,Name ="Pen Drive"},
                new ProductViewModel(){Id=2,Name ="Memory Card"},
                new ProductViewModel(){Id=3,Name ="Mobile Phone"},
                new ProductViewModel(){Id=4,Name ="Desktop PC"}
            };
        }
    }
}
