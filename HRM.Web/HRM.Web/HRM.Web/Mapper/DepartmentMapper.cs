//using HRM.ApplicatonCore.Models;
//using HRM.Web.ViewModels;

//namespace HRM.Web.Mapper
//{
//    public static class DepartmentMapper
//    {
//        // K ma bind garne                 Ka bata aauxa
//        public static DepartmentViewModel ToViewModel(this Department department)
//        {
//            DepartmentViewModel departmentViewModel = new()
//            {
//                Id = department.Id,
//                Name = department.Name,
//                Description = department.Description,
//                Established = department.Established,

//            };
//            return departmentViewModel;

//        }
//        public static Department ToModel(this DepartmentViewModel departmentViewModel)
//        {
//            Department department = new()
//            {
//                Id = departmentViewModel.Id,
//                Name = departmentViewModel.Name,
//                Description = departmentViewModel.Description,
//                Established = departmentViewModel.Established
//            };
//            return department;
//        }

//        // model bata view model ma bind
//        public static List<DepartmentViewModel> ToViewModel(this List<Department> departments)
//        {
//            var departmentViewModels = departments.Select(x => ToViewModel(x)).ToList();
//            return departmentViewModels;
//        }

//        // view model bata Model ma bind
//        public static List<Department> ToModel(this List<DepartmentViewModel> departmentViewModels)
//        {
//            var departments = departmentViewModels.Select(x => ToModel(x)).ToList();
//            return departments;
//        }
//    }
//}
