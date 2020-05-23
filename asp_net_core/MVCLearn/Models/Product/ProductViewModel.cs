namespace MVCLearn.Models
{
   public class ProductViewModel
{
    public int ProductId { get; set; }
    public string Name { get; set; }
 
    public decimal Price { get; set; }
    public int Rating { get; set; }
 
    public string BrandName { get; set; }
    public string SupplierName { get; set; }
 
    public string getRating()
    {
        if (Rating == 10)
        {
            return "*****";
        }
        else if (Rating >=8 )
        {
            return "****"; 
        }
        else if (Rating >= 6)
        {
            return "***"; 
        }
        else if (Rating >= 4)
        {
            return "**"; 
        }
        else 
        {
           return "*"; 
        }
    }
}
}