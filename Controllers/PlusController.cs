using BaoTest1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaoTest1.Controllers
{
    public class PlusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PlusView(int num1, int num2)
        {
            ProductViewModel pr = new ProductViewModel();
            pr.num1 = num1; 
            pr.num2 = num2; 
            pr.result = num1 + num2; ;
            //ViewBag.result = num1 + num2;
            //ViewBag.num1 = num1;
            //ViewBag.num2 = num2;
            return View(pr);
        }


    }
}
