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
        public async Task<IActionResult> AddEdit(int id)
        {
            var categoryVM = await _categoryService.GetByIdAsync(id);
            return View(categoryVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(CategoryVM entityVM)
        {
            //Impedir Null, En Categorias
            ViewBag.message = null;
            if (!ModelState.IsValid) return View(entityVM);

            if (entityVM.CategoryId == 0)
            {
                await _categoryService.AddAsync(entityVM);
                ModelState.Clear();
                entityVM = new CategoryVM();
                ViewBag.message = "Created Category";
            }
            else
            {
                await _categoryService.EditAsync(entityVM);
                ViewBag.message = "Edited Category";
            }
            return View(entityVM);
        }

        /*Metodo Delete*/
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}


