using Microsoft.AspNetCore.Mvc;

namespace My_Shop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() { return View(); }
        public IActionResult Details() { return View();}
    }
}
