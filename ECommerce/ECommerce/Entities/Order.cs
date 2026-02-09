using Microsoft.AspNetCore.SignalR;

namespace ECommerce.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount { get; set; }

        public User? User { get; set; } /*Pueden Ingresar Vacios*/
    }
}

