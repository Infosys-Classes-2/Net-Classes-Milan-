using HRM.ApplicatonCore.Models;
using HRM.Web.ViewModels;

namespace HRM.Web.Mapper
{
    public static class DesignationMapper
    {
        public static DesignationViewModel ToViewModel(Designation designation)
        {
            DesignationViewModel designationViewModel = new()
            {
                Id = designation.Id,
                title = designation.title,
                category = designation.category,
                Description =designation.category
            };
            return designationViewModel;
        }
        public static Designation ToModel(DesignationViewModel designationViewModel)
        {
            Designation desginaiton = new()
            {
                Id=designationViewModel.Id,
                title= designationViewModel.title,
                category= designationViewModel.category,
                Description= designationViewModel.Description,
            };
            return desginaiton;
        }

        public static List<DesignationViewModel> ToViewModel(this List<Designation> designations)
        {
            var designationViewModels = designations.Select(x => ToViewModel(x)).ToList();
            return designationViewModels;
        }
        public static List<Designation> ToModel(this List<DesignationViewModel> designationViewModels)
        {
            var desginations = designationViewModels.Select(x => ToModel(x)).ToList();
            return desginations;

        }

    }
}
