using Microsoft.AspNetCore.Mvc;
using ECommerce.Services;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class UserController(OrderService _orderService): Controller
    {
        public async Task<IActionResult> MyOrders()
        {
            var userId = 1;
            var ordersvm = await _orderService.GetAllByUserAsync(userId);

            return View(ordersvm);

        }
    }


}
