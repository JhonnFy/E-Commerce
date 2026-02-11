using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class CategoryVM
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
