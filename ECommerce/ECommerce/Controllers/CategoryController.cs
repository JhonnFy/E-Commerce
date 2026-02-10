using Microsoft.AspNetCore.Mvc;
using ECommerce.Context;
using System.Threading.Tasks;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class CategoryController(CategoryService _categoryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            /*Consultar Categorias Con El Servicio*/
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
            
        }
    }
}


