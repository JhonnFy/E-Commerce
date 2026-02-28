using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

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
        public async Task<IActionResult> Login(LoginVM viewmodel)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.message = "Todos Los Campos Son Obligatorios";
                ViewBag.Class = "warning";
                return View(viewmodel);
            }

            var found = await _userService.Login(viewmodel);

            if (found.UserId == 0)
            {
                ViewBag.message = "Datos De Acceso Incorrectos";
                ViewBag.Class = "error";
                return View(viewmodel);
            }
            else
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, found.UserId.ToString()),
                    new Claim(ClaimTypes.Name, found.FullName),
                    new Claim(ClaimTypes.Email, found.Email),
                    new Claim(ClaimTypes.Role, found.Type)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme
                );

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties() { AllowRefresh = true }
                );

                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Register()
        {
            var viewModel = new UserVM();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserVM viewmodel)
        {
            if (!ModelState.IsValid)
                return View(viewmodel);

            try
            {
                await _userService.Register(viewmodel);

                ModelState.Clear();

                ViewBag.message = "Cuenta Registrada.";
                ViewBag.Class = "success";
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                ViewBag.Class = "error";
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}