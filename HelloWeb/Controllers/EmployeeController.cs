using HRM.Web.Data;
using HRM.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HRM.Web.Controllers;

public class EmployeeController : Controller
{
    // Tightly coupled code
    private readonly EmployeeContext db;

    // Dependency injection (DI), built-in
    public EmployeeController(EmployeeContext _db)
    {
        db = _db;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var employees = await db.Employees.Include(x => x.Department).Include(y => y.Designation).ToListAsync();

        return View(employees);
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });
        var designations = await db.Designations.ToListAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        });

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(Employee emp)
    {
        // Save profile image to "profile-images" folder        
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "profile-images");

        Directory.CreateDirectory(folderPath);

        var uniqueImageName = $"{Guid.NewGuid():D}_{emp.Avatar.FileName}";
        var filePath = Path.Combine(folderPath, uniqueImageName);

        using FileStream fileStream = new(filePath, FileMode.Create);
        emp.Avatar.CopyTo(fileStream);

        emp.ProfileImage = uniqueImageName;

        await db.Employees.AddAsync(emp);
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(List));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var departments = await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });

        var designations = await db.Designations.ToListAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.Title,
            Value = x.Id.ToString()
        });

        var employee = await db.Employees.FindAsync(id);
        return View(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Employee emp)
    {
        db.Employees.Update(emp);
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(List));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee emp)
    {
        db.Employees.Remove(emp);
        db.SaveChanges();

        return RedirectToAction(nameof(List));
    }

    // Using ADO.NET
    public void GetPeople()
    {
        // Using ADO.NET
        string connectionString =
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=TestDb;"
            + "Integrated Security=true";

        string queryString = "SELECT * from person";

        using (SqlConnection connection = new(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new(queryString, connection);

            // Open the connection in a try/catch block.
            // Create and execute the DataReader, writing the result
            // set to the console window.
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}