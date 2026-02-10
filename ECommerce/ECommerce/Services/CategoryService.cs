using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;

namespace ECommerce.Services
{
    public class CategoryService(GenericRepository<Category> _categoryRepository)
    {
        /*Listar*/
        public async Task<IEnumerable<CategoryVM>> GetAllAsync()
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

        /*Agregar*/
        public async Task AddAsync(CategoryVM viewModel)
        {
            var entity = new Category
            {
                Name = viewModel.Name,
            };
            await _categoryRepository.AddAsync(entity);
        }

        /*Actualizar Id*/
        public async Task<CategoryVM?> GetByIdAsync(int id)
        {
            //CargaDesdeLaDb
            var category = await _categoryRepository.GetByIdAsync(id);

            var categoryVM = new CategoryVM();

            if (category != null)
            {
                categoryVM.Name = category.Name;
                categoryVM.CategoryId = category.CategoryId;
            }

            return categoryVM;

        }

        /*Edit*/
        public async Task EditAsync(CategoryVM viewModel)
        {
            var entity = new Category
            {
                CategoryId = viewModel.CategoryId,
                Name = viewModel.Name,
            };
            await _categoryRepository.EditAsync(entity);
        }

        /*Delete*/
        public async Task DeleteAsync(int id)
        {
             var category = await _categoryRepository.GetByIdAsync(id);
             await _categoryRepository.DeleteAsync(category!);
        }

    }
}
