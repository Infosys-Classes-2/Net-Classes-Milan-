using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.ApplicationCore.Models
{
    public  class RecipeStep

    {
        public int Id { get; set; }
        public int StepNumber { get; set; } 
        public string Instructions { get; set; }


    }
}
