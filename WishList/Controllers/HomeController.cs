using Microsoft.AspNetCore.Mvc;
using System;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
