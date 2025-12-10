using Microsoft.AspNetCore.Mvc;
using Central_Sports.Models;
using System.Linq;
using System.Text.Json;

namespace Central_Sports.Controllers
{
    public class WinkelwagenController : Controller
    {
        public IActionResult Index()
        {
            var cart = GetCartFromSession();
            return View("~/Views/Home/Winkelwagen.cshtml", cart);
        }

        [HttpPost]
        public IActionResult AddToCart(int id, string name, decimal price)
        {
            var cart = GetCartFromSession();
            cart.Add(new Product { Id = id, Name = name, Price = price });
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
            return RedirectToAction("Index", "Product");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int id)
        {
            var cart = GetCartFromSession();
            var item = cart.FirstOrDefault(p => p.Id == id);
            if (item != null)
            {
                cart.Remove(item);
                HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
            }
            return RedirectToAction("Index");
        }

        private List<Product> GetCartFromSession()
        {
            var cartJson = HttpContext.Session.GetString("Cart");
            return string.IsNullOrEmpty(cartJson)
                ? new List<Product>()
                : JsonSerializer.Deserialize<List<Product>>(cartJson)!;
        }
    }
}
