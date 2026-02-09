using Microsoft.AspNetCore.Mvc;
using ECommerce.Context;
using ECommerce.Entities;

namespace ECommerce.Controllers
{
    public class CategoryController(AppDbContext _dbContext) : Controller
    {
        public IActionResult Index()
        {
            /*Consultar Todas Las Categorias. Category se usa en el llamado de la vista*/
            var categories = _dbContext.Category.ToList();
            /*Retornar La Vista Objeto*/
            return View(categories);
        }
    }
}


