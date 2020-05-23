namespace MVCLearn.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer(){
            CustomerId = 1;
            Name = "Kiet";
            Address = "Tra Vinh";

        }
    }
}