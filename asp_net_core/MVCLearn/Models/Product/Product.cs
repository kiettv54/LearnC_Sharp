
namespace MVCLearn.Models
{
    public class Product
    {
       public int ProductId { get; set; }
       public string Name { get; set; }
       public decimal Price { get; set; }
       public int Rating { get; set; }
       public Brand Brand { get; set; }
       public Supplier Supplier { get; set; }

        
    }
}