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
        public IActionResult Index()
        {
            ProductsViewModel viewModel = new ProductsViewModel();
            viewModel.Products = service.GetProducts();
            return View(viewModel);
        }
    }
}
