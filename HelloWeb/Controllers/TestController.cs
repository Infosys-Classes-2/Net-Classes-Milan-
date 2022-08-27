using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Multiply(int num)
        {
            return View(num);
        }
        public IActionResult AssignmentTwo() 
        {
            List<int> numbers = new List<int>();
            return View(); 
        }
    }
}
