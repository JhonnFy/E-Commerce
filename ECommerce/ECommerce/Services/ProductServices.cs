using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;
using System.Linq.Expressions;

namespace ECommerce.Services
{
    public class ProductServices(
    
        /*Dependencias*/
        GenericRepository<Category> _categoryRepository,
        GenericRepository<Product> _productRepository,

        /*Eniva Las Imagenes a wwwroot*/
        IWebHostEnvironment _webHostEnvironment
        )

    {
        /*Metodo Para Listar Productos*/
        public async Task<IEnumerable<ProductVM>>GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync(
                includes: new Expression<Func<Product, object>>[] {x => x.Category!}
                );

            var productVM = products.Select(item =>
                new ProductVM
                {
                    ProductId = item.ProductId,
                    Category = new CategoryVM
                    {
                        CategoryId = item.Category!.CategoryId,
                        Name = item.Category!.Name,
                    },
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Stock = item.Stock,
                    ImageName = item.ImageName,
                }).ToList();

            return productVM;
        }
    }
            







    }
}
