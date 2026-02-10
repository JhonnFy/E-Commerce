using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;

namespace ECommerce.Services
{
    public class CategoryService(GenericRepository<Category> _categoryRepository)
    {
        /*Los Servicios Funcionan De Forma Unica*/

        public async Task<IEnumerable<CategoryVM>>GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            var categoriesVM = categories.Select(item => 
            new CategoryVM
            {
                CategoryId = item.CategoryId,
                Name = item.Name
            }
            ).ToList();

            return categoriesVM;
        }
    }
}
