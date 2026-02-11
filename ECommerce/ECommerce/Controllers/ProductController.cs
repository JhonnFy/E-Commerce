using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using ECommerce.Services;

namespace ECommerce.Controllers
{
    public class ProductController(ProductServices _productServices) : Controller
    {
        public async Task<IActionResult> Index()
        {
            /*Consultar Productos Con El Servicio*/
            var products = await _productServices.GetAllAsync();
            return View(products);
        }

        //Vista Para Agregar
        [HttpGet]
        public async Task<IActionResult> AddEdit(int id)
        {
            var productVM = await _productServices.GetByIdAsync(id);
            return View(productVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(ProductVM entityVM)
        {
            //Campos Eliminados De La Validacion
            ViewBag.message = null;
            ModelState.Remove("Categories");
            ModelState.Remove("Category.Name");
            if (!ModelState.IsValid) return View(entityVM);

            if (entityVM.ProductId == 0)
            {
                await _productServices.AddAsync(entityVM);
                ModelState.Clear();
                entityVM = new ProductVM();
                ViewBag.message = "Created Product";
            }
            else
            {
                await _productServices.EditAsync(entityVM);
                ViewBag.message = "Edited Product";
            }
            return View(entityVM);
        }

        /*Metodo Delete*/
        public async Task<IActionResult> Delete(int id)
        {
            await _productServices.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
