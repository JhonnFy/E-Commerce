using System.Diagnostics;
using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class HomeController (
        //Intanciar Servicios
        CategoryService _categoryService,
        ProductServices _productServices
        ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productServices.GetCatalogAsync();
            var catalog = new CatalogVM { Categories = categories, Products = products };

            return View(catalog);
        }

        public async Task<IActionResult> FilterByCategory(int id, string name)
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productServices.GetCatalogAsync(categoryId:id);

            var catalog = new CatalogVM { Categories = categories, Products = products, filterBy=name };

            return View("index",catalog);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
