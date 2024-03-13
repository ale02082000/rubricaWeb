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


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
