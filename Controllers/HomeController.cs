using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Microsoft.AspNetCore.Authorization;

namespace App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Authorize]
    public IActionResult Dashboard()
    {
        return View();
    }
    [Authorize]
    public IActionResult Csharp()
    {
        return View();
    }
    [Authorize]
    public IActionResult Django()
    {
        return View();
    }
    [Authorize]
    public IActionResult Python()
    {
        return View();
    }
    public IActionResult Flutter()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
