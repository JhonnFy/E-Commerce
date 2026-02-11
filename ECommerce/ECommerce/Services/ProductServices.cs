using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
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
        /*Metodo Para Listar Productos-Cat*/
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
                    CreatedAt = item.CreatedAt,
                }).ToList();

            return productVM;
        }
    

        //Metodo Que Retorna Un Producto Por Id
        public async Task<ProductVM>GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var categories = await _categoryRepository.GetAllAsync();

            var productVM = new ProductVM();

            if(product != null)
            {
                productVM = new ProductVM
                {
                    ProductId = product.ProductId,
                    Category = new CategoryVM
                    {
                        CategoryId = product.Category!.CategoryId,
                        Name = product.Category.Name,
                    },
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                    ImageName = product.ImageName,
                    CreatedAt = product.CreatedAt,
                };
            }

            productVM.Categories = categories.Select(item => new SelectListItem
            {
                Value = item.CategoryId.ToString(),
                Text = item.Name,
            }).ToList();

            return productVM;
        }

        //Agregar Producto
        public async Task AddAsync(ProductVM viewModel)
        {
            if (viewModel.ImageFile !=null)
            {
                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(viewModel.ImageFile.FileName);
                string filePath = Path.Combine(uploadFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                    await viewModel.ImageFile.CopyToAsync(fileStream);

                viewModel.ImageName = uniqueFileName;
            }

            /*Producto dB*/
            var entity = new Product
            {
                CategoryId = viewModel.Category.CategoryId,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Stock = viewModel.Stock,
                ImageName = viewModel.ImageName,
                CreatedAt = DateTime.Now,
            };


            /*Agrega el Producto a la DB*/
            await _productRepository.AddAsync(entity);
        }

        //Actualizar Producto 
        public async Task EditAsync(ProductVM viewModel)
        {
            var product = await _productRepository.GetByIdAsync(viewModel.ProductId);

            if (viewModel.ImageFile !=null)
            {
                string uploaderFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(viewModel.ImageFile.FileName);
                string filePath = Path.Combine(uploaderFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                await viewModel.ImageFile.CopyToAsync(fileStream);

                if (!product.ImageName.IsNullOrEmpty()) 
                {
                    var previousImage = product.ImageName;
                    string deleteFilePath = Path.Combine(uploaderFolder, previousImage);

                    if (File.Exists(deleteFilePath)) File.Delete(deleteFilePath);
                }

                viewModel.ImageName = uniqueFileName;
            }

            else
            {
                viewModel.ImageName = product.ImageName;
            }

            product.CategoryId = viewModel.Category.CategoryId;
            product.Name = viewModel.Name;
            product.Description = viewModel.Description;
            product.Price = viewModel.Price;
            product.Stock = viewModel.Stock;
            product.ImageName = viewModel.ImageName;
            product.CreatedAt = DateTime.Now;
            await _productRepository.EditAsync(product);

        }


        //Eliminar Producto
        public async Task DeleteAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }


        //Metodo Para Alimentar Catalog
        public async Task<IEnumerable<ProductVM>> GetCatalogAsync(int categoryId=0, string search = "")
        {

            //Condicionales
            var conditions = new List<Expression<Func<Product,bool>>>
                {
                    x=> x.Stock > 0, //Stock Mayor a 0
                };

            if (categoryId != 0) conditions.Add(x => x.CategoryId == categoryId);
            if (!string.IsNullOrEmpty(search)) conditions.Add(x => x.Name.Contains(search));

            var products = await _productRepository.GetAllAsync(conditions: conditions.ToArray());

            var productVM = products.Select(item =>
                new ProductVM
                {
                    ProductId = item.ProductId,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Stock = item.Stock,
                    ImageName = item.ImageName,
                    CreatedAt = item.CreatedAt,
                }).ToList();

            return productVM;
        }

    }
}
