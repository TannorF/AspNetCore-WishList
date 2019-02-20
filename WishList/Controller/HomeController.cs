using Microsoft.AspNetCore.Mvc;

namespace WishList.Controller
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
