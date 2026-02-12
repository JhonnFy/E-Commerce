namespace ECommerce.Models
{
    public class CartItemVM
    {
        //Informacion Del Producto
        public int ProductId { get; set; }
        public string ImageName { get; set; }
        public string Name { get; set;  }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
