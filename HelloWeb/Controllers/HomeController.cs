using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;

namespace HelloWeb.Controllers;
public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public string test()
    {
        return "Hello there";
    }

}
