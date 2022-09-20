using HRM.ApplicatonCore.Models;
using HRM.Web.Mapper;
using HRM.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HRM.Infrastructure.Repository;

public class EmployeeController : Controller
{
    //Tightly coupled code --alternet of tightly coupled is dependency injection 
    //EmployeContext db = new(); 

    //dependency injection(DI), built-in
    private readonly EmployeeRepository employeeRepository;
    private readonly DepartmentRepository departmentRepository;
    private readonly DesignationRepository designationRepository;
    private readonly IHostEnvironment host;
    
    public EmployeeController(EmployeeRepository employeeRepository, DepartmentRepository departmentRepository, DesignationRepository designationRepository, IHostEnvironment host)
    {
        this.employeeRepository = employeeRepository;
        this.departmentRepository = departmentRepository;
        this.designationRepository = designationRepository;
        this.host = host;
    }

    [HttpGet]
    public async Task<IActionResult>Add()
    {
        var departments = await departmentRepository.GetAllAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });
        
        var designation = await designationRepository.GetAllAsync();
        ViewData["Designations"] = designation.Select(x => new SelectListItem()
        {
            Text = x.title,
            Value = x.Id.ToString()
        });
        return View();

    }
    [HttpPost]
    public IActionResult Add(EmployeeViewModel employeeViewModel)
    {     

        employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        employeeViewModel.Active = true;

       var employee= employeeViewModel.ToModel();

        employeeRepository.AddAsync(employee);
              //db.Employees.Add(employee); 
        //db.SaveChanges();
        return RedirectToAction(nameof(List));
        
    }

    public async Task<IActionResult> Edit(int id)
    {
        var departments = await departmentRepository.GetAllAsync();
        ViewData["Departments"] = departments.Select(x => new SelectListItem()
        {
            Text = x.Name,
            Value = x.Id.ToString()
        });

        var designations = await designationRepository.GetAllAsync();
        ViewData["Designations"] = designations.Select(x => new SelectListItem()
        {
            Text = x.title,
            Value = x.Id.ToString()
        });

        var employee = await employeeRepository.GetAsync(id);

        return View(employee.ToViewModel());
    }

    [HttpPost]
    public IActionResult Edit(EmployeeViewModel employeeViewModel)
    {
        if(employeeViewModel.Avatar is not null)
        {
            employeeViewModel.ProfileImage = SaveProfileImage(employeeViewModel.Avatar);
        }               
       
        var employee = employeeViewModel.ToModel();
        employeeRepository.EditAsync(employee);
        return RedirectToAction(nameof(List));

    }
    [HttpGet]
    public IActionResult Delete(int ID)
    {
      var employee = employeeRepository.GetAsync(ID);
        return View(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(Employee emp)
    {
        var employee = await employeeRepository.GetAsync(emp.id);
        employee.Active = false;
        employeeRepository.CommitAsync();
        return RedirectToAction(nameof(List));

    }


    //using async wait
    public async Task<IActionResult> List(string searchText)
    {
       // Employees Repository vitra ko getall method lai caall garera search text pathako

        var employees = await employeeRepository.GetallAsync(searchText);

        return View(employees.ToViewModel());
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
