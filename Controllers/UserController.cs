using BaoTest1.Models;
using BaoTest1.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BaoTest1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn(string? userName, string? pass)
        {
            if(userName == null && pass == null) { return View(); }
            LogInViewModel vm = new LogInViewModel();
            var rs = CheckLogin(userName, pass);
            if (rs)
            {
                vm.message = "Success";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                vm.message = "False";
            }
            return View(vm);
        }

        bool CheckLogin(string? loginName, string? pass)
        {
            if(loginName == null || pass == null) {
                return false;
            }
            if(loginName == "NgocBao" &&  pass =="311203")
            {
                return true;
            }else
                return false;
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}
