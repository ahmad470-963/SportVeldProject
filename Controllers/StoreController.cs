using Microsoft.AspNetCore.Mvc;
using Central_Sports.Models;

public class StoreController : Controller
{
    public IActionResult Index()
    {
        var producten = GetProducten();
        return View(producten);
    }

    public IActionResult Details(int id)
    {
        var producten = GetProducten();

        var product = producten.FirstOrDefault(p => p.Id == id);

        if (product == null)
            return NotFound();

        return View(product);
    }

    private List<Product> GetProducten()
    {
        return new List<Product>()
        {
            new Product { Id = 1, Naam = "Zaal Schoenen", Beschrijving = "Officiële schoenen van de club", Prijs = 30.50m, AfbeeldingUrl = "/images/schoenen.png" },
            new Product { Id = 2, Naam = "tennisballen", Beschrijving = "tennis ballen die je bij de balie kunt huren", Prijs = 5.00m, AfbeeldingUrl = "/images/ballen.png" }
        };
    }
}
