using HRM.ApplicatonCore.Models;
using HRM.Web.ViewModels;
using System.Reflection.Metadata.Ecma335;

namespace HRM.Web.Mapper
{
    public static class DepartmentMapper
    {
        // Department bata aako data lai Department View model ma map gareko
        // K ma data pathaune                   ||    Ka bata data aauxa  
        public static DepartmentViewModel ToViewModel(this Department department)
        {
            DepartmentViewModel departmentViewModel = new()
            {
                Description = department.Description,
                Id= department.Id,
                Name=department.Name,
                Established =department.Established
            };
            return departmentViewModel ;
        }
        // DepartmentViewModel bata aako data lai department ma haleko
        public static Department ToModel(this DepartmentViewModel departmentViewModel)
        {
            Department department = new()
            {
                Name = departmentViewModel.Name,
                Id = departmentViewModel.Id,
                Description = departmentViewModel.Description,
                Established = departmentViewModel.Established
                            };
            return department;
        }
        public static List<DepartmentViewModel> ToViewModel(this List<Department>  departmnets) 
        {
            var departmentViewModels = departmnets.Select(x => ToViewModel(x)).ToList();
            return departmentViewModels;
        }
        public static List <Department> ToModel(this List<DepartmentViewModel> departmentViewModels)
        {
            var departments = departmentViewModels.Select(x => ToModel(x)).ToList();
            return departments;
        }

    }
}
