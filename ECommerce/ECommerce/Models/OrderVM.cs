namespace ECommerce.Models
{
    public class OrderVM
    {
        public string OrderDate { get; set; }
        public string TotalAmount { get; set; }
        public ICollection<OrderItemVM>? OrderItems { get; set;}

    }
}
