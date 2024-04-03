using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using rubricaWeb.Models;

namespace rubricaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        StreamReader fin = new StreamReader("data/dati.csv");

        List<string> lista = new();
        lista.Add("Maurizio");
        lista.Add("Marco");
        lista.Add("Luca"); 
        return View(lista);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

     public IActionResult Gelati()
    {
        List<Gelato> list = new List<Gelato>();
        list.Add(new Gelato { Id = 1, Nome = "Puffo", Descrizione = "Gelato azzurro" });
        list.Add(new Gelato { Id = 2, Nome = "Nutella", Descrizione = "Gelato al cioccolato con nutella" });
        list.Add(new Gelato { Id = 3, Nome = "Bacio", Descrizione = "Gelato al cioccolato con nocciole" });
        list.Add(new Gelato { Id = 4, Nome = "Fiordilatte", Descrizione = "Gelato al latte" });
        return View(list);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
