using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class Product
    {
        public int ProductId {get; set;}
        public int CategoryId {get ; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Description { get; set;}
        public decimal Price { get; set;}
        public int Stock { get; set; }
        public string? ImageName { get; set; } = null; /*Pueden Ingresar Vacios*/

        //Propiedad Para Fecha
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Fk Category
        public Category? Category { get; set; }
    }
}
