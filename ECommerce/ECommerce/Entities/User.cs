using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public class User
    {
        public int UserId { get; set; } /*Pk*/
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Type { get; set; }

        //¿Que orden tiene un usuario?
        public ICollection<Order> Orders { get; set; }
    }
}
