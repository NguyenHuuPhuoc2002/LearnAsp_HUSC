using BaoTest1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace BaoTest1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Detail()
        {
            var stList = new List<String>()
            {
                "Ngoc bao",
                "Huu Phuoc",
                "Anh Tan",
                 "Ton Lep",
                "Quang Phu",
                "Anh Tan",
                 "Ngoc bao",
                "Huu Phuoc",
                "Anh Tan",
                 "Ngoc bao",
                "Huu Phuoc",
                "Anh Tan",
                 "Ngoc bao",
                "Huu Phuoc",
                "Anh Tan",

            };
            string keyword = HttpContext.Request.Query["keyword"];
            if(!string.IsNullOrEmpty(keyword))
            {
                stList = stList.Where(x => x.ToLower().Contains(keyword.ToLower())).OrderBy(e => e).ToList();
                
            }
            ViewBag.stList = stList;
             

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
