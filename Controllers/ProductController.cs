using Microsoft.AspNetCore.Mvc;
using Central_Sports.Models;
using System.Text.Json;

namespace Central_Sports.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View("~/Views/Home/Product.cshtml");
        }
    }
}
