using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class AccountController(UserService _userService) : Controller
    {
        public IActionResult Login()
        {
            var viewModel = new LoginVM();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult>Login(LoginVM viewmodel)
        {
            if(!ModelState.IsValid) return View(viewmodel);
            var found = await _userService.Login(viewmodel);

            if(found.UserId ==0)
            {
                ViewBag.message = "No Matches Found";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }
    }
}
