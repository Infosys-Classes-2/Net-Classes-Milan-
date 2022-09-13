using HRM.Infrastructure.Data;
using HRM.ApplicatonCore.Models;
using HRM.Web.Mapper;

using HRM.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

public class EmployeeController : Controller
{
    //Tightly coupled code --alternet of tightly coupled is dependency injection 
    //EmployeContext db = new(); 

    //dependency injection(DI), built-in
    private readonly EmployeContext db;
    private readonly IHostEnvironment host;
    
    public EmployeeController(EmployeContext _db, IHostEnvironment host)
    {
        this.db = _db;
        this.host = host;
    }
    [HttpGet]
    public async Task<IActionResult>Add()
    {
        var departments= await db.Departments.ToListAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });
        
        var designation = await db.Designations.ToListAsync();
        ViewData["Designations"] = designation.Select(x => new SelectListItem()
        {
            Text = x.title,
            Value = x.Id.ToString()
        });
        return View();

    }
    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {        //Add to db
        //  EmployeContext db = new();
        //Save profile image to "profile-images" folder --Path.Combine combines multiple paths
        // var folderPath = Path.Combine(host.ContentRootPath, "profile-images");

        /*var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "profile-images");
                Directory.CreateDirectory(folderPath);
        var uniqueImageName = $"{Guid.NewGuid():D}_ {employee.Avatar.FileName}";
        var filePath =Path.Combine(folderPath , uniqueImageName);

        FileStream fileStream = new FileStream(filePath,FileMode.Create);

        employee.Avatar.CopyTo(fileStream);
        fileStream.Close();

        //    employee.profileImage = filePath; or 
        employee.ProfileImage = uniqueImageName;*/

        employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        employeeViewModel.Active = true;

       var employee= employeeViewModel.ToModel();

        db.Employees.Add(employee);
         db.SaveChanges();
              //db.Employees.Add(employee); 
        //db.SaveChanges();
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
            Text = x.title,
            Value = x.Id.ToString()
        });

        var employee = await db.Employees.FindAsync(id);

        return View(employee.ToViewModel());
    }

    [HttpPost]
    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        if(employeeViewModel.Avatar is not null)
        {
            employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        }               
        //Add to db
        //  EmployeContext db = new();
        var employee = employeeViewModel.ToModel();
        db.Employees.Update(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(List));

    }
    [HttpGet]
    public IActionResult Delete(int ID)
    {
        var employee = db.Employees.Find(ID);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee emp)
    {
        var employee = db.Employees.Find(emp.id);
        employee.Active = false;
        db.Employees.Remove(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(List));

    }


    //using async wait
    public async Task<IActionResult> List(string searchText)
    {
        //var employees = await db.Employees.ToListAsync();
        //var employees = await db.Employees.Include(x => x.Department).Include(y=>y.Designation).ToListAsync();
        // var queryEmployees = from employee in employees
        //                      join dept in db.Departments on employee.DepartmentId equals dept.Id
        //                     select new
        //                     {
        //                          Name = employee.FirstName,
        //                        Department=dept.Name
        //                             };
        var employees = await db.Employees
            .Where(e=> e.Active.Value && string.IsNullOrEmpty(searchText)  //short-circuit
                || e.FirstName.Contains(searchText) 
                || e.LastName.Contains(searchText))
            .Include(x=>x.Department)
            .Include(y=>y.Designation).ToListAsync();

        var employeeViewModels = employees.ToViewModel();
       
        //true or false = true,
        return View(employeeViewModels);
    }

    private static string SaveProfileImage(IFormFile avatar)
    {
        //Save profile image to "profile-images" folder --Path.Combine combines multiple paths
        // var folderPath = Path.Combine(host.ContentRootPath, "profile-images");
        // Save profile image to "profile-images" folder        
        var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "profile-images");

        Directory.CreateDirectory(folderPath);

        var uniqueImageName = $"{Guid.NewGuid():D}_{avatar.FileName}";
        var filePath = Path.Combine(folderPath, uniqueImageName);

        using FileStream fileStream = new(filePath, FileMode.Create);
        avatar.CopyTo(fileStream);

        return uniqueImageName;
    }


}
