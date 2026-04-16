using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
namespace ProductApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var res=Product.GetProducts();
            return View(res);
        }
    }
}
