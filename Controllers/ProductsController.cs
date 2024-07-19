using BaoTest1.Services;
using BaoTest1.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BaoTest1.Controllers
{
    public class ProductsController : Controller
    {
        ProductsService service;
        public ProductsController() { 
            service = new ProductsService();
        }
        public IActionResult Index(String? keyword)
        {
            ProductsViewModel viewModel = new ProductsViewModel();
            viewModel.keyword = keyword
            viewModel.Products = service.GetProducts(String ? keyword);
            return View(viewModel);
        }
    }
}
