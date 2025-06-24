using Microsoft.AspNetCore.Mvc;

namespace My_Shop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
