using ECommerce.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ProductVM
    {
        public int ProductId { get; set; }
        public CategoryVM Category { get; set; }

        public List<SelectListItem> Categories { get; set; }

        [Required]
        public string Name { get; set; }
       
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        public string? ImageName { get; set; } = null; /*Pueden Ingresar Vacios*/

        /*CreatedAt*/
        public DateTime CreatedAt { get; set; }

        /*Consume Las Img*/
        public IFormFile? ImageFile { get; set; }

    }
}
