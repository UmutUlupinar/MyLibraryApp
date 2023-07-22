using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyLibrary.MVC.Models;
using MyLibrary.MVC.Services;

namespace MyLibrary.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBookServices _bookServices;

    public HomeController(ILogger<HomeController> logger,IBookServices bookServices)
    {
        _logger = logger;
        _bookServices = bookServices;
    }

    public IActionResult Index()
    {
        var books = _bookServices.GetAllBooks();
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}