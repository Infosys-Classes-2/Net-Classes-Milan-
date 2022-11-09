using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.ApplicationCore.Models
{
    public class NutritionalInformation
    {
        public int Id { get; set; }
        public string NutritionName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Recipe> Recipe { get; set; }
    }
}
