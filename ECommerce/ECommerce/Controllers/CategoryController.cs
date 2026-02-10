using Microsoft.AspNetCore.Mvc;
using ECommerce.Context;
using System.Threading.Tasks;
using ECommerce.Services;
using ECommerce.Models;

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

        //Vista Para Agregar
        [HttpGet]
        public async Task<IActionResult> AddEdit()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>AddEdit(CategoryVM entityVM)
        {
            //Impedir Null, En Categorias
            ViewBag.message = null;
            if (!ModelState.IsValid) return View(entityVM);

            await _categoryService.AddAsync(entityVM);
            ViewBag.message = "Categoria Agregada";
            return View();
        }


    }
}


