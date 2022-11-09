using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookery.ApplicationCore.Models
{
    public class Measurement
    {
        public int Id { get; set; }
        public string MeasurementName { get; set; }
        public string Abbreviation { get; set; }
        public bool IsActive { get; set; }

        public ICollection<NutritionalInformation> NutritionalInformation { get; set; }

    }
}
