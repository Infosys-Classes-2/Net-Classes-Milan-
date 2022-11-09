using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.ApplicationCore.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime PreprationTime { get; set; }
        public DateTime CookingTime { get; set; }
        public string OrginCountry { get; set; }

        // recipe ma dherai instructions hunxa kasari banaune vanera
        //public RecipeStep RecipeStep { get; set; }
        public ICollection<RecipeStep> RecipeStep { get; set; } 
        public Difficulty Difficulty { get; set; }



    }
}
