using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using HRM.ApplicatonCore.Models;

namespace HRM.Web.Controllers
{
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
    
       

    }
}