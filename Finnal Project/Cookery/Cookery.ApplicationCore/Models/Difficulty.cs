using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.ApplicationCore.Models
{
    public class Difficulty
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsActive { get; set; }

       // euta difficulty level ma dherai recipe hunxa
       public ICollection<Recipe> Recipe { get; set; }
    }   
}
