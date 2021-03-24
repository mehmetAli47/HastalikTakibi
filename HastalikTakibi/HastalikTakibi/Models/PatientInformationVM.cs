using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HastalikTakibi.Models
{
    public class PatientInformationVM
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DiseaseId { get; set; }
        public int CategoryId { get; set; }
        public DateTime WhenIll { get; set; }
        public DateTime? RecoveryTime { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
        public string Symptoms { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

       

        
    }
}
