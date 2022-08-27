using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;
namespace HelloWeb.Controllers;

public class EmployeeController : Controller
{


    static List<Employee> employees = new()
        { new()
        {
           Id = 1,
            FirstName = "samir",
            LastName = "khadka",
            Designaton = "Software Engineer",
            Level = 3,
            Department = "WEbDEV",
            JoinDate = DateTime.Now}

           , new()
            {
               Id=2,
               FirstName = "Milan",
            LastName = "Dhakal",
            Designaton = "Software Engineer",
            Level = 1,
            Department= "WEbDEV",
            JoinDate = DateTime.Now }
        };    // List of Employee

    public IActionResult List()
    {
        return View(employees);
    }


    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Employee emp) //    <Employee> model ho <employee> chai variable aafai le banako
    {

        // Adding to the Employee List
        employees.Add(emp);
        return RedirectToAction(nameof(List));
    }

    public IActionResult Edit(int id)
    {
        return View(employees[id]);
    }
}
