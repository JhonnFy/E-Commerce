using Microsoft.AspNetCore.Mvc;
using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Models;

namespace ECommerce.Controllers
{
    public class CategoryController(AppDbContext _dbContext) : Controller
    {
        public IActionResult Index()
        {
            /*Consultar Todas Las Categorias. Category se usa en el llamado de la vista*/
            var categories = _dbContext.Category.Select(item =>
            new CategoryVM
            {
                CategoryId = item.CategoryId,
                Name = item.Name,
            }).ToList();
            /*Retornar La Vista Objeto*/
            return View(categories);
        }
    }
}


