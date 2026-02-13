using Microsoft.AspNetCore.Mvc;
using ECommerce.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;


namespace ECommerce.Controllers
{
    [Authorize]
    public class UserController(OrderService _orderService): Controller
    {
        public async Task<IActionResult> MyOrders()
        {
            
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            var ordersvm = await _orderService.GetAllByUserAsync(int.Parse(userId));
            return View(ordersvm);

        }
    }


}
