using ECommerce.Entities;
using ECommerce.Models;
using ECommerce.Services;
using ECommerce.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Diagnostics;
using System.Text.Json;

namespace ECommerce.Controllers
{
    public class HomeController (
        //Intanciar Servicios
        CategoryService _categoryService,
        ProductServices _productServices
        ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productServices.GetCatalogAsync();
            var catalog = new CatalogVM { Categories = categories, Products = products };

            return View(catalog);
        }


        //Filter by category
        public async Task<IActionResult> FilterByCategory(int id, string name)
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productServices.GetCatalogAsync(categoryId:id);

            var catalog = new CatalogVM { Categories = categories, Products = products, filterBy=name};

            return View("Index", catalog);
        }

        //Search
        public async Task<IActionResult> FilterBySearch(string value)
        {
            var categories = await _categoryService.GetAllAsync();
            var products = await _productServices.GetCatalogAsync(search: value);

            var catalog = new CatalogVM { Categories = categories, Products = products, filterBy = $"Results for: {value}"};

            return View("Index",catalog);
        }


        //Metodo Para El Detalle del Producto
        public async Task<IActionResult>ProductDetail(int id)
        {
            var product = await _productServices.GetByIdAsync(id);
            return View(product);
        }

        [HttpPost]
        //Carrito De Compras
        public async Task<IActionResult> AddItemToCart(int productId, int quantity)
        {
            //Retornar Id
            var product = await _productServices.GetByIdAsync(productId);

            var cart = HttpContext.Session.Get<List<CartItemVM>>("Cart")?? new List<CartItemVM>();

            if (cart.Find(x=> x.ProductId == productId) == null)
            {
                cart.Add(new CartItemVM
                {
                    ProductId = productId,
                    ImageName = product.ImageName,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity
                });
            }else
            {
                var updateProduct = cart.Find(x => x.ProductId == productId);
                updateProduct!.Quantity += quantity;
            }

            HttpContext.Session.Set("Cart", cart);
            ViewBag.message = "Product Added To Cart";
            return View("ProductDetail", product);
        }

        //Metodo Para Retornar Los Producos Del Carro
        public IActionResult ViewCart()
        {
            var cart = HttpContext.Session.Get<List<CartItemVM>>("Cart") ?? new List<CartItemVM>();
            return View(cart);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
